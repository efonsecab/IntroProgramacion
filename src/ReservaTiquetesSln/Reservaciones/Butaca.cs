using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones
{
    public class Butaca
    {
        /*
         * Posicion
         * A-1
         * A-2
         * A-3
         * A-4
         * E-1...E-4
         * */
        public string Posicion { get; set; }
        public bool Reservada { get; set; }

        public Butaca(string strPosicion)
        {
            Posicion = strPosicion;
        }
    }
}
