using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce el valor de x: ");

        if (double.TryParse(Console.ReadLine(), out double x))
        {
            if (x > 0.0 && x <= 50.0)
            {
                double y;

                if (x <= 10.9)
                {
                    y = 8.7 + x;
                    Console.WriteLine($"El valor de y es: {y}");
                }
                else if (x <= 21.6)
                {
                    y = 16 * x;
                    Console.WriteLine($"El valor de y es: {y}");
                }
                else
                {
                    y = 24 / x;
                    Console.WriteLine($"El valor de y es: {y}");
                }
            }
            else
            {
                Console.WriteLine("El valor de x debe estar entre 0.0 y 50.0.");
            }
        }
        else
        {
            Console.WriteLine("El valor ingresado no es válido. Debe ser un número.");
        }
    }
}
