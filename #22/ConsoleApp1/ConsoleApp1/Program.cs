using System;

class Program
{
    public static void Main()
    {
        double ladoA, ladoB, ladoC;
        bool esValido;

        do
        {
            Console.Write("Ingrese el valor del lado A del triángulo (número positivo): ");
            esValido = double.TryParse(Console.ReadLine(), out ladoA) && ladoA > 0;

            if (!esValido)
            {
                Console.WriteLine("Por favor, ingrese un número positivo válido para el lado A.");
            }
        } while (!esValido);

        do
        {
            Console.Write("Ingrese el valor del lado B del triángulo (número positivo): ");
            esValido = double.TryParse(Console.ReadLine(), out ladoB) && ladoB > 0;

            if (!esValido)
            {
                Console.WriteLine("Por favor, ingrese un número positivo válido para el lado B.");
            }
        } while (!esValido);

        do
        {
            Console.Write("Ingrese el valor del lado C del triángulo (número positivo): ");
            esValido = double.TryParse(Console.ReadLine(), out ladoC) && ladoC > 0;

            if (!esValido)
            {
                Console.WriteLine("Por favor, ingrese un número positivo válido para el lado C.");
            }
        } while (!esValido);

        if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
        {
            double perimetro = ladoA + ladoB + ladoC;

            double semiperimetro = perimetro / 2;
            double area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));

            Console.WriteLine("\nEl perímetro del triángulo es: " + perimetro);
            Console.WriteLine("El área del triángulo es: " + area);
        }
        else
        {
            Console.WriteLine("\nLos valores ingresados no pueden formar un triángulo.");
        }
    }
}
