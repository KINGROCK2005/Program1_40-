using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = LeerNumero("Ingrese el número para imprimir su tabla de multiplicar: ");

        Console.WriteLine($"\nTabla de multiplicar de {numero} en orden inverso:");
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }

    static int LeerNumero(string mensaje)
    {
        int numero;
        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out numero))
                return numero;
            Console.WriteLine("Error: Por favor ingrese un número entero válido.");
        }
    }
}

