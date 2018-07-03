﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
    public class ListaPagosDeDeudas
    {
        public int idPago { get; set; }
        public string Cliente { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
