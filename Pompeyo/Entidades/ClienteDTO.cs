﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteDTO
    {
        public int id { get; set; }
        public string rut { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string giro { get; set; }
    }
}
