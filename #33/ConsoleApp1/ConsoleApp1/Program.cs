using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce el primer número entero positivo: ");
        if (int.TryParse(Console.ReadLine(), out int numero1) && numero1 > 0)
        {
            Console.Write("Introduce el segundo número entero positivo: ");
            if (int.TryParse(Console.ReadLine(), out int numero2) && numero2 > 0)
            {
                if (numero1 != numero2)
                {
                    int diferencia = Math.Abs(numero1 - numero2);
                    Console.WriteLine($"La diferencia entre el mayor y el menor número es: {diferencia}");
                }
                else
                {
                    Console.WriteLine("Los números deben ser distintos.");
                }
            }
            else
            {
                Console.WriteLine("El segundo número ingresado no es válido. Debe ser un número entero positivo.");
            }
        }
        else
        {
            Console.WriteLine("El primer número ingresado no es válido. Debe ser un número entero positivo.");
        }
    }
}
