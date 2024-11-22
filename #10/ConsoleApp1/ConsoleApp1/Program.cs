using System;

class Program
{
    static void Main()
    {
        int n;
        bool esValido;

        do
        {
            Console.Write("Ingrese un número entero positivo para N: ");
            string entrada = Console.ReadLine();

            esValido = int.TryParse(entrada, out n) && n > 0;

            if (!esValido)
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo válido.");
            }

        } while (!esValido); 

        int suma = 0;
        int numero = 6; 

        for (int i = 0; i < n; i++)
        {
            suma += numero;
            numero += 2; 
        }

        Console.WriteLine("La suma de los primeros " + n + " números pares mayores a 4 es: " + suma);
    }
}
