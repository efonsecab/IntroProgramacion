using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP_ConsoleApp
{
    /*
     * Persona
     * Vehículo
     * Casa
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo objVehiculo = new Vehiculo();
            //objVehiculo.Color = Color.Morado;
            int aceleracion = 0;
            while (aceleracion <= 100)
            {
                objVehiculo.Acelerar(aceleracion);
                int tmpAceleracion = objVehiculo.ObtenerAceleracionActual();
                Console.WriteLine(string.Format("La aceleración actual es: {0}", tmpAceleracion));
                aceleracion = aceleracion + 1;
            }
            objVehiculo.Detenerse();
            Console.WriteLine(string.Format("La aceleración actual es: {0}", objVehiculo.ObtenerAceleracionActual()));
            Color[] colores = new Color[] { Color.Verde, Color.Azul };
            Casa objCasa = new Casa(colores);

            Persona objPersona = CrearPersona("1", "Juan", "Castillo", "Brenes", "Pasaporte");
            Persona objPersona2 = CrearPersona("3", "María", "Sánchez", "Rodríguez", "Cédula");

            Persona objPersona3 = CrearPersona("3", "María", "Sánchez", "Rodríguez", "Cédula");

            if (objPersona2 == objPersona3)
                Console.WriteLine("Son iguales");

            else
                Console.WriteLine("Son diferentes");


            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }

        private static Persona CrearPersona(
            string identificador, string nombre, string primerApellido,
            string segundoApellido, string tipoDeDocumento
            )
        {
            Persona objPersona = new Persona(tipoDeDocumento);
            objPersona.Identificador = identificador;
            var a = objPersona.Identificador;
            objPersona.Nombre = nombre;
            objPersona.PrimerApellido = primerApellido;
            objPersona.SegundoApellido = segundoApellido;
            //objPersona.TipoDeDocumento = tipoDeDocumento;
            return objPersona;
        }
    }
}
