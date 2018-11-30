using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class MarcaNegocio
    {
        private MarcaDAL dal = new MarcaDAL();

        public SimpleDTO crear(string descripcion) {

            if (descripcion == null || descripcion != null && descripcion.Trim() == "") {

                throw new Exception(Constantes.CAMPO_REQUERIDO);
            }

            return dal.crear(descripcion.ToUpper());
        }

        public List<SimpleDTO> listar() {

            return dal.listar();
        }

        public bool eliminar(SimpleDTO dto)
        {
            return dal.eliminar(dto);
        }
    }
}
