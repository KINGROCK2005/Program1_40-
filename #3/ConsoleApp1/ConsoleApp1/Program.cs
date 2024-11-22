using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    internal class CalcuMate
    {

        public static void Main()
        {

            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double suma = num1 + num2;
            double resta = num1 - num2;
            double producto = num1 * num2;
            double division = num2 != 0 ? num1 / num2 : 0;
            /**/
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Resta: " + resta);
            Console.WriteLine("Producto: " + producto);
            if (num2 != 0)
            {
                Console.WriteLine("División: " + division);
            }
            else
            {
                Console.WriteLine("División: No se puede dividir entre cero.");
            }
        }
    }
}