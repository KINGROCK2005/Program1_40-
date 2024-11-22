using System;

class Program
{
    public static void Main()
    {
        int n;
        bool esValido;

        do
        {
            Console.Write("Ingrese un número entero no negativo para calcular su factorial: ");
            string entrada = Console.ReadLine();
            esValido = int.TryParse(entrada, out n) && n >= 0;

            if (!esValido)
            {
                Console.WriteLine("Por favor, ingrese un número entero no negativo válido.");
            }

        } while (!esValido); 

        long factorial = CalcularFactorial(n);

        Console.WriteLine("El factorial de " + n + " es: " + factorial);
    }

    static long CalcularFactorial(int numero)
    {
        long resultado = 1;
        for (int i = 1; i <= numero; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
}
