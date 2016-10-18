using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP_ConsoleApp
{
    public enum Color
    {
        Rojo,
        Verde,
        Azul,
        Negro,
        Morado,
        Amarillo
    }
    class Vehiculo
    {
        public Color Color = Color.Azul;
        public string Modelo;
        public int CantidadMarchas;
        public int CapacidadMotorCC;
        private int AceleracionActual = 0;
        
        public void Acelerar(int aceleracion)
        {
            this.AceleracionActual = aceleracion;
        }

        public int ObtenerAceleracionActual()
        {
            return this.AceleracionActual;
        }

        public void Detenerse()
        {
            this.AceleracionActual = 0;
        }
    }
}
