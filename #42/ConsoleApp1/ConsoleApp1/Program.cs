using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce el salario del asegurado: ");

        if (decimal.TryParse(Console.ReadLine(), out decimal salario) && salario >= 0)
        {
            Console.Write("Introduce la condición del asegurado (activo/inactivo): ");
            string condicion = Console.ReadLine().Trim().ToLower();

            decimal cuota;

            if (condicion == "activo")
            {
                cuota = salario * 0.10m;
                Console.WriteLine($"La cuota mensual del asegurado es: {cuota} córdobas.");
            }
            else if (condicion == "inactivo")
            {
                cuota = salario * 0.05m;
                Console.WriteLine($"La cuota mensual del asegurado es: {cuota} córdobas.");
            }
            else
            {
                Console.WriteLine("La condición del asegurado no es válida. Debe ser 'activo' o 'inactivo'.");
            }
        }
        else
        {
            Console.WriteLine("El salario ingresado no es válido. Debe ser un número positivo.");
        }
    }
}
