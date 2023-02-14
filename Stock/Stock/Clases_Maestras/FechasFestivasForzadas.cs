using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Clases_Maestras
{
    public class FechasFestivasForzadas
    {
        public static DateTime ForzarFecha()
        {
            int AñoActual = DateTime.Now.Year; ;
            DateTime FechaActual;
            ///// Fin de Año
            FechaActual = Convert.ToDateTime("27/12/2022");

            ///// Reyes           
            //FechaActual = Convert.ToDateTime("02/01/2023");
            ///// Carnaval        
            //FechaActual = Convert.ToDateTime("14/02/2023");
            ///// Malvinas          
            //FechaActual = Convert.ToDateTime("02/04/2023");
            ///// Pascuas          
            //FechaActual = Convert.ToDateTime("06/04/2023");
            ///// 9 de Julio
            //AñoActual = AñoActual + 1;
            //FechaActual = Convert.ToDateTime("09/07/2023");

            return FechaActual;
        }
    }
}
