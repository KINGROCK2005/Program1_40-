using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce un número (x): ");
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            Console.WriteLine($"Resultados de {x}³ hasta ({x} + 15)³:");
            CalcularPotencias(x);
        }
        else
        {
            Console.WriteLine("El valor de 'x' no es válido. Debe ser un número entero.");
        }
    }

    static void CalcularPotencias(int x)
    {
        for (int i = x; i <= x + 15; i++)
        {
            Console.WriteLine($"{i}³ = {Math.Pow(i, 3)}");
        }
    }
}
