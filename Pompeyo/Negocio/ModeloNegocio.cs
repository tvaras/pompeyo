using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class ModeloNegocio
    {
        private ModeloDAL dal = new ModeloDAL();

        public ModeloDTO crear(int idMarca, string descripcion, int valor)
        {

            if (descripcion == null || descripcion != null && descripcion.Trim() == "") {

                throw new Exception(Constantes.CAMPO_REQUERIDO);
            }

            if (valor <= 0) {

                throw new Exception(Constantes.MAYOR_A_CERO);
            }

            return dal.crear(idMarca, descripcion.ToUpper(), valor);
        }

        public List<ModeloDTO> listar()
        {

            return dal.listar();
        }

        public ModeloDTO buscar(int id)
        {

            return dal.buscar(id);
        }

        public List<ModeloDTO> listarDTO()
        {

            return dal.listarDTO();
        }

        public List<ModeloDTO> listarDTOCombo()
        {

            return dal.listarDTOCombo();
        }

        public bool eliminar(ModeloDTO dto)
        {
            return dal.eliminar(dto);
        }
    }
}
