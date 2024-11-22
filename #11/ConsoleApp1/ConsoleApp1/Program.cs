// Susing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    internal class _11Matriz
    {
        public static void Main()
        {
            Console.Write("Ingrese el tamaño de la matriz identidad (n x n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] matrizIdentidad = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        matrizIdentidad[i, j] = 1;
                    }
                    else
                    {
                        matrizIdentidad[i, j] = 0;
                    }
                }
            }

            Console.WriteLine("\nLa matriz identidad es:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrizIdentidad[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
