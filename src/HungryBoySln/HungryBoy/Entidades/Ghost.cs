using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HungryBoy.Entidades
{
    public class Ghost
    {
        public ArrowDirection MovementDiretion;
        public int FilaActual;
        public int ColumnActual;
        public PictureBox Imagen;
        public Ghost(int f, int c, PictureBox p)
        {
            FilaActual = f;
            ColumnActual = c;
            Imagen = p;
            MovementDiretion = ArrowDirection.Up;
        }
    }
}
