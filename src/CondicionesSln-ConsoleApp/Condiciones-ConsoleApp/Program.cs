using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condiciones_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un número entero válido");
            string strOperandoIzquierdo = Console.ReadLine();
            int iOperandoIzquierdo = 0;
            bool bValidOpIzq = Int32.TryParse(strOperandoIzquierdo, out iOperandoIzquierdo);
            if (bValidOpIzq == false)
                Console.WriteLine(string.Format("El valor {0} no es un número entero válido", strOperandoIzquierdo));
            Console.WriteLine("Digite un número entero válido");
            string strOperandoDerecho = Console.ReadLine();
            int iOperandoDerecho = 0;
            bool bValidOpder = Int32.TryParse(strOperandoDerecho, out iOperandoDerecho);
            if (bValidOpder == false)
                Console.WriteLine(string.Format("El valor {0} no es un número entero válido", strOperandoDerecho));
            if (bValidOpIzq && bValidOpder)
            {
                Console.WriteLine("Digite uno de los siguientes signos para selecciona la operación");
                Console.WriteLine("+ (Suma))");
                Console.WriteLine("- (Resta)");
                Console.WriteLine("x (Multiplicación)");
                Console.WriteLine("/ (División)");
                ConsoleKeyInfo operacion = Console.ReadKey();
                Console.WriteLine();
                switch (operacion.KeyChar)
                {
                    case '+':
                        int resultadoSuma = iOperandoIzquierdo + iOperandoDerecho;
                        Console.WriteLine(string.Format("El resultado de sumar {0} más {1} es: {2}", iOperandoIzquierdo, iOperandoDerecho, resultadoSuma));
                        break;
                    case '-':
                        int resultadoResta= iOperandoIzquierdo - iOperandoDerecho;
                        Console.WriteLine(string.Format("El resultado de restar {0} menos {1} es: {2}", iOperandoIzquierdo, iOperandoDerecho, resultadoResta));
                        break;
                    case 'x':
                        long resultadoMultiplicacion = iOperandoIzquierdo * iOperandoDerecho;
                        Console.WriteLine(string.Format("El resultado de multiplicar {0} por {1} es: {2}", iOperandoIzquierdo, iOperandoDerecho, resultadoMultiplicacion));
                        break;
                    case '/':
                        if (iOperandoDerecho != 0)
                        {
                            var resultadoDivison = iOperandoIzquierdo / iOperandoDerecho;
                            Console.WriteLine(string.Format("El resultado de dividir {0} entre {1} es: {2}", iOperandoIzquierdo, iOperandoDerecho, resultadoDivison));
                        }
                        else
                        {
                            Console.WriteLine("Error!. No se puede dividir entre 0");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("No se puede continuar la operación");
            }
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
