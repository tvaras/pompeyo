using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class ModeloDAL
    {
        public ModeloDTO crear(int idMarca, string descripcion, int valor)
        {
            Modelo entidad = new Modelo { idMarca = idMarca, nombre = descripcion, valor = valor };

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                entidad = dbo.Modelo.Add(entidad);
                dbo.SaveChanges();
            }

            return new ModeloDTO() {
                idMarca = entidad.idMarca,
                idModelo = entidad.idModelo,
                modelo = entidad.nombre,
                valor = entidad.valor
            };
        }

        public List<ModeloDTO> listar()
        {
            List<ModeloDTO> entidades = new List<ModeloDTO>();

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                entidades = (from u in dbo.Modelo select new ModeloDTO
                {
                    idMarca = u.idMarca,
                    idModelo = u.idModelo,
                    marca = u.Marca.nombre,
                    modelo = u.nombre,
                    valor = u.valor
                }).ToList<ModeloDTO>();
            }

            return entidades;
        }

        public ModeloDTO buscar(int id)
        {
            ModeloDTO entidad = new ModeloDTO();

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                entidad = (from u in dbo.Modelo
                           where u.idModelo == id
                           select new ModeloDTO
                           {
                               idMarca = u.idMarca,
                               idModelo = u.idModelo,
                               marca = u.Marca.nombre,
                               modelo = u.nombre,
                               valor = u.valor
                           }).FirstOrDefault<ModeloDTO>();
            }

            return entidad;
        }

        public List<ModeloDTO> listarDTO()
        {
            List<ModeloDTO> entidades = new List<ModeloDTO>();

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                entidades = (from u in dbo.Modelo select new ModeloDTO { 
                    idMarca = u.idMarca,
                    idModelo = u.idModelo,
                    marca = u.Marca.nombre,
                    modelo = u.nombre,
                    valor = u.valor
                }).ToList<ModeloDTO>();
            }

            return entidades;
        }

        public List<ModeloDTO> listarDTOCombo()
        {
            List<ModeloDTO> entidades = new List<ModeloDTO>();

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                entidades = (from u in dbo.Modelo
                             select new ModeloDTO
                             {
                                 idMarca = u.idMarca,
                                 idModelo = u.idModelo,
                                 marca = u.Marca.nombre,
                                 modelo = u.nombre + " - $" + u.valor,
                                 valor = u.valor
                             }).ToList<ModeloDTO>();
            }

            return entidades;
        }

        public bool eliminar(ModeloDTO m) {

            Modelo entidad = new Modelo {
                idMarca = m.idMarca,
                idModelo = m.idModelo,
                nombre = m.modelo,
                valor = m.valor
            };

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                dbo.Modelo.Attach(entidad);
                entidad = dbo.Modelo.Remove(entidad);
                dbo.SaveChanges();
                return true;
            }
        }
    }
}
