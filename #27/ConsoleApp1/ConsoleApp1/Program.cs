using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cálculo de la suma de 1000 números y sus raíces cuadradas.");

        double suma = CalcularSumaYRaizCuadrada(1000);

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Suma total: {suma}");
    }

    static double CalcularSumaYRaizCuadrada(int cantidad)
    {
        double suma = 0;

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write($"Ingrese el número {i}: ");
            double numero = LeerNumeroPositivo(); 

            suma += numero;
            Console.WriteLine($"Raíz cuadrada de {numero}: {Math.Sqrt(numero):F2}");
        }

        return suma;
    }

    static double LeerNumeroPositivo()
    {
        double numero;
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out numero) && numero >= 0)
                return numero;
            Console.WriteLine("Error: Ingrese un número positivo.");
        }
    }
}
