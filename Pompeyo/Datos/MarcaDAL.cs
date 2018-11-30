using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class MarcaDAL
    {
        public SimpleDTO crear(string descripcion)
        {
            Marca entidad = new Marca { nombre = descripcion };

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                entidad = dbo.Marca.Add(entidad);
                dbo.SaveChanges();
            }

            return new SimpleDTO() {
                id = entidad.idMarca,
                descripcion = entidad.nombre
            };
        }

        public List<SimpleDTO> listar()
        {
            List<SimpleDTO> entidades = new List<SimpleDTO>();

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                entidades = (from u in dbo.Marca
                             select new SimpleDTO { id = u.idMarca, descripcion = u.nombre }).ToList();
            }

            return entidades;
        }

        public bool eliminar(SimpleDTO dto)
        {
            Marca entidad = new Marca { idMarca = dto.id, nombre = dto.descripcion };

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                dbo.Marca.Attach(entidad);
                entidad = dbo.Marca.Remove(entidad);
                dbo.SaveChanges();
            }

            return entidad == null;
        }
    }
}
