using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce un número (x): ");
        if (double.TryParse(Console.ReadLine(), out double x))
        {
            if (x < 0)
            {
                double resultado = x - 2;
                Console.WriteLine($"El número es negativo. Resultado: {resultado}");
            }
            else
            {
                double resultado = x + 2;
                Console.WriteLine($"El número es positivo o cero. Resultado: {resultado}");
            }
        }
        else
        {
            Console.WriteLine("El valor ingresado no es válido. Debe ser un número.");
        }
    }
}
