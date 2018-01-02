using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace Stock.Clases_Maestras
{
    public class Funciones
    {
        //public Funciones()
        //{
        //    //
        //    // TODO: Agregar aquí la lógica del constructor
        //    //
        //}
        public static Bitmap byteToBipmap(byte[] fotoByte)
        {
            MemoryStream ms = new MemoryStream(fotoByte);
            return (Bitmap)Bitmap.FromStream(ms);
        }
        public static Bitmap byteToBipmap2(byte[] fotoByte2)
        {
            MemoryStream ms2 = new MemoryStream(fotoByte2);
            return (Bitmap)Bitmap.FromStream(ms2);
        }
    }
}
