using System;

class Program
{
    static void Main(string[] args)
    {

        decimal salario, ventas;

        Console.Write("Introduce el total de ventas mensuales del vendedor (en córdobas): ");

        if (decimal.TryParse(Console.ReadLine(), out  ventas) && ventas >= 0)
        {

            if (ventas < 50)
            {
                salario = ventas;
            }
            else if (ventas <= 500)
            {
                salario = ventas + (ventas * 0.10m);
            }
            else
            {
                salario = 500 + ((ventas - 500) * 0.08m) + 50;
            }

            Console.WriteLine($"El salario total del vendedor es: {salario} córdobas.");
        }
        else
        {
            Console.WriteLine("El valor ingresado no es válido. Debe ser un número positivo.");
        }
    }
}
