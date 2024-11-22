using System;

class Program
{
    public static void Main()
    {
        int numeroInicial;
        bool esValido;

        do
        {
            Console.Write("Ingrese el número inicial (entero): ");
            string entrada = Console.ReadLine();
            esValido = int.TryParse(entrada, out numeroInicial);

            if (!esValido)
            {
                Console.WriteLine("Por favor, ingrese un número entero válido.");
            }

        } while (!esValido); 

        int suma = 0;

        for (int i = 0; i < 100; i++)
        {
            suma += numeroInicial + i;
        }

        // Mostrar el resultado
        Console.WriteLine("La suma de los 100 números consecutivos comenzando desde " + numeroInicial + " es: " + suma);
    }
}
