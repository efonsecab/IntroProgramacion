using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP_ConsoleApp
{
    class Casa
    {
        public string Ubicacion;
        public int Identificador;
        public Color[] Colores = new Color[] { Color.Amarillo, Color.Azul, Color.Negro };

        public Casa()
        {

        }
        public Casa(Color[] colores)
        {
            this.Colores = colores;
        }
    }
}
