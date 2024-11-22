using System;

class Program
{
    public static void Main()
    {
        int n;
        bool esValido;

        do
        {
            Console.Write("Ingrese un número entero positivo para n: ");
            string entrada = Console.ReadLine();
            esValido = int.TryParse(entrada, out n) && n > 0;

            if (!esValido)
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo.");
            }
        } while (!esValido);

        long suma = 0;

        for (int i = 1; i <= n; i++)
        {
            suma += (long)Math.Pow(i, i);
        }

        Console.WriteLine($"La suma de la serie es: {suma}");
    }
}


