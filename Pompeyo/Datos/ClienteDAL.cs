using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class ClienteDAL
    {
        public ClienteDTO crear(string rut, string nombre, string direccion, string giro)
        {
            Cliente entidad = new Cliente { rut = rut, nombre = nombre,
                dirección = direccion, Giro = giro };

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                entidad = dbo.Cliente.Add(entidad);
                dbo.SaveChanges();
            }

            return new ClienteDTO() {
                rut = entidad.rut,
                nombre = entidad.nombre,
                direccion = entidad.dirección,
                giro = entidad.Giro,
                id = entidad.idCliente
            };
        }

        public List<ClienteDTO> listar()
        {
            List<ClienteDTO> entidades = new List<ClienteDTO>();

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                entidades = (from u in dbo.Cliente select new ClienteDTO()
                {
                    rut = u.rut,
                    nombre = u.nombre,
                    direccion = u.dirección,
                    giro = u.Giro,
                    id = u.idCliente
                }).ToList<ClienteDTO>();
            }

            return entidades;
        }

        public ClienteDTO buscar(int id)
        {
            ClienteDTO entidad = new ClienteDTO();

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                entidad = (from u in dbo.Cliente
                           where u.idCliente == id
                           select new ClienteDTO() {
                    rut = u.rut,
                    nombre = u.nombre,
                    direccion = u.dirección,
                    giro = u.Giro,
                    id = u.idCliente
                }).First<ClienteDTO>();
            }

            return entidad;
        }

        public List<ClienteDTO> listarDTO()
        {
            List<ClienteDTO> entidades = new List<ClienteDTO>();

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                entidades = (from u in dbo.Cliente
                             select new ClienteDTO
                             {
                                 rut = u.rut,
                                 nombre = u.nombre,
                                 direccion = u.dirección,
                                 giro = u.Giro,
                                 id = u.idCliente
                             }).ToList<ClienteDTO>();
            }

            return entidades;
        }

        public List<ClienteDTO> listarDTOCombo()
        {
            List<ClienteDTO> entidades = new List<ClienteDTO>();

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                entidades = (from u in dbo.Cliente
                             select new ClienteDTO
                             {
                                 rut = u.rut,
                                 nombre = u.rut + " - " + u.nombre,
                                 direccion = u.dirección,
                                 giro = u.Giro,
                                 id = u.idCliente,

                             }).ToList<ClienteDTO>();
            }

            return entidades;
        }

        public bool eliminar(ClienteDTO c)
        {
            Cliente entidad = new Cliente() {
                idCliente = c.id,
                rut = c.rut,
                nombre = c.nombre,
                dirección = c.direccion,
                Giro = c.giro
            };
            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                dbo.Cliente.Attach(entidad);
                entidad = dbo.Cliente.Remove(entidad);
                dbo.SaveChanges();
                return true;
            }
        }
    }
}
