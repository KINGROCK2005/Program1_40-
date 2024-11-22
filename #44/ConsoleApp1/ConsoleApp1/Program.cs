using System;

class Program
{
    static void Main(string[] args)
    {
        decimal salario=0;
        bool salarioValido = false;

        while (!salarioValido)
        {
            Console.Write("Introduce el salario del trabajador en dólares: ");
            string entrada = Console.ReadLine();

            if (decimal.TryParse(entrada, out salario) && salario >= 0)
            {
                salarioValido = true; 
            }
            else
            {
                Console.WriteLine("El salario ingresado no es válido. Debe ser un número positivo. Inténtalo nuevamente.");
            }
        }

        decimal aumento;

        if (salario < 900)
        {
            aumento = salario * 0.25m;
        }
        else if (salario <= 1000)
        {
            aumento = salario * 0.20m;
        }
        else if (salario > 2000)
        {
            aumento = salario * 0.18m;
        }
        else
        {
            aumento = 0;
        }

        decimal nuevoSalario = salario + aumento;
        Console.WriteLine($"El nuevo salario del trabajador es: {nuevoSalario} dólares.");
    }
}




