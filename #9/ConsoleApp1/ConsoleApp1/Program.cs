using System;

class Program
{
    public static void Main()
    {
        int numero;
        bool esValido;

        do
        {
            Console.Write("Ingrese un número entero: ");
            string nument = Console.ReadLine();

            esValido = int.TryParse(nument, out numero);

            if (!esValido)
            {
                Console.WriteLine("Por favor, ingrese un número entero válido.");
            }

        } while (!esValido); 

        if (numero == 0)
        {
            Console.WriteLine("El número no es par ni impar.");
        }
        else if (numero % 2 == 0)
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }
    }
}

