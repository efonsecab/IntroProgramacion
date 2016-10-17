// Doble slash significa línea de comentarios(no se compilan, son comentarios para los desarrolladores
/*
 * Comentario de múltiples líneas se comienza con un "/" segudi de un "*" para marcar el inicio
 * del comentarios, se coloca un "*" seguido de un "/" para marcar el final del comentario
 * */

/*
 * Líneas using: indican los namespaces(espacios de nombres) que quremos importar
 * Líneas using en gris: indicador al desarrollador, significa que estamos importando namespaces que no estamos utilizando
 * 
 * ; significa final de instrucción
 * */

// Ver https://www.youtube.com/playlist?list=PLGPt1G9l1TyzOUsMF06wSoBS5zd5Tjh9i

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fecha y Hora Actual: " + DateTime.Now);
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
