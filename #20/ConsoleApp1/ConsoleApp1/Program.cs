using System;

class Program
{
    static void Main()
    {
        int n1, n2, n3, n4, n5;

        Console.WriteLine("Ingrese cinco números (máximo 6 dígitos):");
        n1 = LeerNumeroConValidacion("Número 1: ");
        n2 = LeerNumeroConValidacion("Número 2: ");
        n3 = LeerNumeroConValidacion("Número 3: ");
        n4 = LeerNumeroConValidacion("Número 4: ");
        n5 = LeerNumeroConValidacion("Número 5: ");

        int mayores = 0, menores = 0, iguales = 0;

        int[] numeros = { n1, n2, n3, n4, n5 };

        foreach (int numero in numeros)
        {
            if (numero > 10)
                mayores++;
            else if (numero < 10)
                menores++;
            else
                iguales++;
        }

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Mayores a 10: {mayores}");
        Console.WriteLine($"Menores a 10: {menores}");
        Console.WriteLine($"Iguales a 10: {iguales}");
    }

    static int LeerNumeroConValidacion(string mensaje)
    {
        int numero;

        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero >= -999999 && numero <= 999999)
                {
                    return numero; 
                }
                else
                {
                    Console.WriteLine("Error: El número debe tener un máximo de 6 dígitos.");
                }
            }
            else
            {
                Console.WriteLine("Error: Entrada no válida. Ingrese un número entero.");
            }
        }
    }
}

