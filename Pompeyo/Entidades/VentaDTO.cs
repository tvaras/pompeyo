using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VentaDTO
    {
        public int idVenta { get; set; }
        public int idModelo { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public int idCliente { get; set; }
        public string rut { get; set; }
        public string cliente { get; set; }
        public System.DateTime fechaCompra { get; set; }
        public int monto { get; set; }
        public int idUsuario { get; set; }
        public string usuario { get; set; }
    }
}
