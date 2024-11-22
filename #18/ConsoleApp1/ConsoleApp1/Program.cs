using System;

class Program
{
    public static void Main()
    {
        int tamaño;
        bool esValido;

        do
        {
            Console.Write("Ingrese el tamaño del arreglo (entero positivo): ");
            string entrada = Console.ReadLine();
            esValido = int.TryParse(entrada, out tamaño) && tamaño > 0;

            if (!esValido)
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo para el tamaño del arreglo.");
            }
        } while (!esValido);

        int[] arreglo = new int[tamaño];

        for (int i = 0; i < tamaño; i++)
        {
            int elemento;
            bool esNumeroValido;

            do
            {
                Console.Write($"Ingrese el elemento {i + 1} del arreglo (entero): ");
                string entradaElemento = Console.ReadLine();
                esNumeroValido = int.TryParse(entradaElemento, out elemento);

                if (!esNumeroValido)
                {
                    Console.WriteLine("Por favor, ingrese un número entero válido.");
                }

            } while (!esNumeroValido);

            arreglo[i] = elemento;
        }

        Console.WriteLine("\nArreglo resultante después de multiplicar cada elemento por 3:");
        for (int i = 0; i < tamaño; i++)
        {
            arreglo[i] *= 3;
            Console.WriteLine("Elemento " + (i + 1) + ": " + arreglo[i]);
        }
    }
}

