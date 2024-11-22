using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce el número de materias a inscribir (máximo 15): ");

        if (int.TryParse(Console.ReadLine(), out int materias) && materias > 0 && materias <= 15)
        { 
            int costoPorMateria = 50;
            int costoTotal = materias * costoPorMateria;

            if (costoTotal > 750)
            {
                costoTotal = 750;
            }

            Console.WriteLine($"El costo total de la colegiatura por {materias} materias es: {costoTotal} córdobas.");
        }
        else
        {
            Console.WriteLine("El número de materias ingresado no es válido. Debe ser un número entero positivo entre 1 y 15.");
        }
    }
}
