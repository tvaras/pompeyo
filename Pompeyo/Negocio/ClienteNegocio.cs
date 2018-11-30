using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class ClienteNegocio
    {
        private ClienteDAL dal = new ClienteDAL();

        public ClienteDTO crear(string rut, string nombre, string direccion, string giro)
        {

            if (rut == null || rut != null && rut.Trim() == "")
            {

                throw new Exception(Constantes.CAMPO_REQUERIDO);
            }

            if (nombre == null || nombre != null && nombre.Trim() == "")
            {

                throw new Exception(Constantes.CAMPO_REQUERIDO);
            }

            if (direccion == null || direccion != null && direccion.Trim() == "")
            {

                throw new Exception(Constantes.CAMPO_REQUERIDO);
            }

            return dal.crear(rut.ToUpper(), nombre.ToUpper(), direccion.ToUpper(), giro.ToUpper());
        }

        public List<ClienteDTO> listar()
        {

            return dal.listar();
        }

        public ClienteDTO buscar(int id)
        {

            return dal.buscar(id);
        }

        public List<ClienteDTO> listarDTO()
        {

            return dal.listarDTO();
        }

        public List<ClienteDTO> listarDTOCombo()
        {

            return dal.listarDTOCombo();
        }

        public bool eliminar(ClienteDTO dto)
        {
            return dal.eliminar(dto);
        }
    }
}
