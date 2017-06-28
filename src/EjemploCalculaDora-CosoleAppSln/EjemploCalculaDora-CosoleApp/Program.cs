using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCalculaDora_CosoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione la operacion");
            Console.WriteLine("+ Suma");
            Console.WriteLine("+ Resta");
            Console.WriteLine("+ Multiplicacion");
            Console.WriteLine("/ Division");
            ConsoleKeyInfo operador = Console.ReadKey();
            if (operador.Key == ConsoleKey.OemPlus)
            {

            }
            if (operador.KeyChar == '+')
            {

            }
            string strOpIzq = string.Empty;
            int iOpIzq = 0;
            int iOpDer = 0;
            int resultado = 0;
            if (operador.KeyChar == '+')
            {
                Console.WriteLine("Digite el primer operando");
                strOpIzq = Console.ReadLine();
                iOpIzq = int.Parse(strOpIzq);
                Console.WriteLine("Digite el segundo operando");
                string strOpder = Console.ReadLine();
                iOpDer = int.Parse(strOpder);
                resultado = iOpIzq + iOpDer;
                Console.WriteLine("Resultado=" + resultado);
            }
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
