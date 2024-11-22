using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce la cantidad de camisas que deseas comprar: ");

        if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
        {
            double precioUnitario;

            if (cantidad > 3)
            {
                precioUnitario = 10;
            }
            else
            {
                precioUnitario = 12;
            }

            double costoTotal = cantidad * precioUnitario;
            Console.WriteLine($"El costo total por {cantidad} camisas es: {costoTotal} córdobas.");
        }
        else
        {
            Console.WriteLine("La cantidad ingresada no es válida. Debe ser un número entero positivo.");
        }
    }
}
