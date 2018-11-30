using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class VentaNegocio
    {
        private VentaDAL dal = new VentaDAL();

        public VentaDTO crear(int idModelo, int idCliente, int monto, int idUsuario)
        {

            if (monto < 0)
            {

                throw new Exception(Constantes.CAMPO_REQUERIDO);
            }

            return dal.crear(idModelo, idCliente, monto, idUsuario);
        }

        public List<VentaDTO> listar()
        {

            return dal.listar();
        }

        public VentaDTO buscar(int id)
        {

            return dal.buscar(id);
        }

        public List<VentaDTO> listarDTO()
        {

            return dal.listarDTO();
        }

        public bool eliminar(VentaDTO dto)
        {
            return dal.eliminar(dto);
        }
    }
}
