using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cálculo de la sumatoria de pares e impares.");
        Console.Write("¿Cuántos números desea ingresar?: ");
        int cantidad = LeerEnteroPositivo();

        int sumaPares = 0, sumaImpares = 0;

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write($"Ingrese el número {i}: ");
            int numero = LeerNumero();

            if (numero % 2 == 0)
                sumaPares += numero;
            else
                sumaImpares += numero;
        }

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Sumatoria de números pares: {sumaPares}");
        Console.WriteLine($"Sumatoria de números impares: {sumaImpares}");
    }

    static int LeerEnteroPositivo()
    {
        int numero;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out numero) && numero > 0)
                return numero;
            Console.WriteLine("Error: Ingrese un número entero positivo.");
        }
    }

    static int LeerNumero()
    {
        int numero;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out numero))
                return numero;
            Console.WriteLine("Error: Ingrese un número entero válido.");
        }
    }
}

