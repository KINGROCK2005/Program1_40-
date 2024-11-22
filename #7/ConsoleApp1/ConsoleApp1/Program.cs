using System;

class Program
{
    public static void Main()
    {
        Console.Write("Ingrese la cantidad de niños: ");
        int cantidadNinos = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la cantidad de niñas: ");
        int cantidadNinas = Convert.ToInt32(Console.ReadLine());

        int totalEstudiantes = cantidadNinos + cantidadNinas;

        double porcentajeNinos = (double)cantidadNinos / totalEstudiantes * 100;
        double porcentajeNinas = (double)cantidadNinas / totalEstudiantes * 100;

        Console.WriteLine("\nPorcentaje de niños: " + porcentajeNinos + "%");
        Console.WriteLine("Porcentaje de niñas: " + porcentajeNinas + "%");
    }
}