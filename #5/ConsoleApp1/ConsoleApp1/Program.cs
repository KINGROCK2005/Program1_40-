using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    internal class _5Prod_Suma
    {
        public static void Main()
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 < 0)
            {
                double producto = num1 * num2 * num3;
                Console.WriteLine("El primer número es negativo. El producto de los tres números es: " + producto);
            }
            else
            {
                double suma = num1 + num2 + num3;
                Console.WriteLine("El primer número no es negativo. La suma de los tres números es: " + suma);
            }
        }
    }
}