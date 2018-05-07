using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Clases_Maestras
{
    public class ValoresConstantes
    {
        public static string[] Perfiles
        {
            get
            {
                return new string[] { "ADMINISTRADOR", "OPERADOR" };
            }
        }
        public static string[] Sexo
        {
            get
            {
                return new string[] { "MASCULINO", "FEMENINO" };
            }
        }

    }
}
