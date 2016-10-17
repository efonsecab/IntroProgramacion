using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecturaDeDatos_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer Datos: Nombre, Primer Apellido, Segundo Apellido, Edad
            Console.WriteLine("Digite su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Digite su primer apellido");
            string primerApellido = Console.ReadLine();
            Console.WriteLine("Digite su segundo apellido");
            string segundoApellido = Console.ReadLine();
            //Console.WriteLine("Su nombre completo es:" + nombre + " " + primerApellido + " " + segundoApellido);
            string lineaAImprimir = string.Format("Su nombre completo es: {0} {1} {2}", nombre, primerApellido, segundoApellido);
            Console.WriteLine(lineaAImprimir);
            Console.WriteLine("Digite su edad");
            string strEdad = Console.ReadLine();
            int edad = 0;
            bool bEdadValid = int.TryParse(strEdad, out edad);
            Console.WriteLine("¿Edad Válida? " + bEdadValid);
            Console.WriteLine("Su edad es: " + edad);
            Console.WriteLine("Digite una tecla para salir");
            Console.ReadKey();
        }
    }
}
