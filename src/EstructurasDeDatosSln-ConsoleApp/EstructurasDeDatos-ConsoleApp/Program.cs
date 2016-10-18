using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray;
            numArray = new int[7];
            numArray[0] = 14;
            numArray[1] = 25;
            numArray[2] = 41;
            numArray[3] = 10;
            numArray[4] = 21;
            numArray[5] = 6;
            numArray[6] = 98;
            //Imprimir(0, numArray);
            //Imprimir(1, numArray);
            //Imprimir(2, numArray);
            //Imprimir(3, numArray);
            //Imprimir(4, numArray);
            //Imprimir(5, numArray);
            //Imprimir(6, numArray);
            int[,] numMatrix = new int[3,3];
            numMatrix[0, 0] = 5;
            numMatrix[0, 1] = 15;
            numMatrix[0, 2] = 8;

            numMatrix[1, 0] = 45;
            numMatrix[1, 1] = 155;
            numMatrix[1, 2] = 82;

            numMatrix[2, 0] = 65;
            numMatrix[2, 1] = 165;
            numMatrix[2, 2] = 28;
            //Imprimir(0, 0, numMatrix);
            //Imprimir(0, 1, numMatrix);
            //Imprimir(0, 2, numMatrix);

            //Imprimir(1, 0, numMatrix);
            //Imprimir(1, 1, numMatrix);
            //Imprimir(1, 2, numMatrix);

            //Imprimir(2, 0, numMatrix);
            //Imprimir(2, 1, numMatrix);
            //Imprimir(2, 2, numMatrix);

            //Uso de ciclos
            int posEnArray = 0;
            while (posEnArray < numArray.Length)
            {
                Imprimir(posEnArray, numArray);
                posEnArray = posEnArray + 1;
            }

            for (int iPos = 0; iPos < numArray.Length; iPos++)
            {
                Imprimir(iPos, numArray);
            }

            foreach (int valor in numArray)
            {
                Console.WriteLine("Valor=" + valor);
            }

            Console.WriteLine("Ejemplo do-while");
            posEnArray = 0;
            do
            {
                Imprimir(posEnArray, numArray);
                posEnArray++;
            } while (posEnArray < numArray.Length);

            Console.WriteLine("Ejemplo for(matriz)");
            for (int f=0; f < numMatrix.GetLength(0); f++)
            {
                for (int c = 0; c < numMatrix.GetLength(1); c++)
                {
                    Imprimir(f, c, numMatrix);
                }
            }
            Console.WriteLine("Presiona una tecla para salir");
            Console.ReadKey();
        }

        private static void Imprimir(int posicion, int[] numArray)
        {
            int valorEnPos = numArray[posicion];
            Console.WriteLine(string.Format("La posición {0} tiene el valor {1}", posicion, valorEnPos));
        }

        private static void Imprimir(int posA, int posB, int[,] numMatrix)
        {
            int valorEnPos = numMatrix[posA, posB];
            Console.WriteLine(string.Format("La posición {0},{1} tiene el valor {2}", posA,posB, valorEnPos));
        }
    }
}
