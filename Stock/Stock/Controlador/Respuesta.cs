﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Controlador
{
   public class Respuesta
    {
        public bool Exito { get; set; }
        public List<string> Errores { get; set; }
        public int Id { get; set; }
    }
}
