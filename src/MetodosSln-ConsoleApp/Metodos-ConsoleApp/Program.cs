using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_ConsoleApp
{
    public class OperacionesAritmeticas
    {
        internal static void MiMetodo()
        {

        }

        /// <summary>
        /// Recibe dosnúmeros y los suma
        /// </summary>
        /// <param name="opIzq">Operando izquierdo en la operación</param>
        /// <param name="opDer">Operando derecho en la operación</param>
        /// <returns></returns>
        public static int Sumar(int opIzq, int opDer)
        {
            return opIzq + opDer;
            //return opDer + opIzq;
        }

        public static bool Dividir(float opIzq, float opDer, out float resultado)
        {
            bool operacionValida = false;
            if (opDer == 0)
            {
                operacionValida = false;
                resultado = 0;
            }
            else
            {
                resultado = (opIzq / opDer);
            }
            return operacionValida;
        }

        /// <summary>
        /// Recibe dos números y los resta
        /// </summary>
        /// <param name="opIzq"></param>
        /// <param name="opDer"></param>
        /// <returns></returns>
        public static int Restar(int opIzq, int opDer)
        {
            return opIzq - opDer;
        }

        public static int Multiplicar(int opIzq, int opDer)
        {
            return opIzq * opDer;
        }

        public static double Dividir(int opIzq, int opDer)
        {
            return opIzq / (double)opDer;
        }

        public double RaizCuadrada(int operando)
        {
            return Math.Sqrt(operando);
        }

        public static double Potencia(int operando, int potencia)
        {
            return Math.Pow(operando, potencia);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float resultadoDiv = 0;
            bool validDiv = OperacionesAritmeticas.Dividir(3, 0, out resultadoDiv);
            //int resultado1 = OperacionesAritmeticas.Sumar(5, 3);
            //int resultado2 = OperacionesAritmeticas.Sumar(5, 7);
            //int resultado3 = OperacionesAritmeticas.Sumar(8, 1);
            int numBase = 2;
            int numExponente = 5;
            double resultadoPotencia = OperacionesAritmeticas.Potencia(numBase, numExponente);
            Console.WriteLine("Ejemplo Potencia {0}^{1}={2} ", numBase, numExponente, resultadoPotencia);
            Console.ReadKey();
        }
    }
}
