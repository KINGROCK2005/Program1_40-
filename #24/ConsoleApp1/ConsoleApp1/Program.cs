using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce un número (x): ");
        if (double.TryParse(Console.ReadLine(), out double x))
        {
            Console.Write("Introduce un número (n): ");
            if (double.TryParse(Console.ReadLine(), out double n))
            {
                double resultado = Calcular(x, n);
                Console.WriteLine($"El resultado es: {resultado}");
            }
            else
            {
                Console.WriteLine("El valor de 'n' no es válido. Debe ser un número.");
            }
        }
        else
        {
            Console.WriteLine("El valor de 'x' no es válido. Debe ser un número.");
        }
    }

    static double Calcular(double x, double n)
    {
        if (x >= 0)
        {
            return Math.Pow(x - 2 * n, 2 * n);
        }
        else
        {
            return Math.Pow(x + 2 * n, 2 * n);
        }
    }
}

