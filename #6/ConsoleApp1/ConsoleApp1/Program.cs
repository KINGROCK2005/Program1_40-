
using System;

namespace Tareas
{
    internal class numMayor
    {
        public static void Main()
        {
            Console.Write("Ingrese un digito: ");
            double num1 = Convert.ToDouble(Console.ReadLine());


            double cuadra=0, raiz=0;

            if (num1 ==0)
            {
                Console.WriteLine("Error: "+num1);
                System.Environment.Exit(1);
            }
            else if (num1 > 0)
            {
                cuadra = num1 * num1;
            }
            else
            {
                raiz=Math.Cbrt(num1);
            }

            Console.WriteLine("Su raiz cuadrada es: " + raiz);
            Console.WriteLine("El número numero al cuadrado es: " + cuadra);
        }
    }
}