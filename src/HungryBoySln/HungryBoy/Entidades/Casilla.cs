using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryBoy.Entidades
{
    public class Casilla
    {
        public char Char;
        public bool HasRedGhost = false;
        public System.Windows.Forms.PictureBox Imagen;

        public Casilla(char pChar, 
            System.Windows.Forms.PictureBox pImagen)
        {
            this.Char = pChar;
            this.Imagen = pImagen;
        }
    }
}
