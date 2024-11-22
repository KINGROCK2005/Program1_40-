using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cálculo de promedio de calificaciones del estudiante.");

        string matricula = LeerMatricula("Ingrese la matrícula del estudiante: ");

        double[] calificaciones = new double[5];
        for (int i = 0; i < 5; i++)
        {
            calificaciones[i] = LeerCalificacion($"Ingrese la calificación {i + 1}: ");
        }

        double promedio = CalcularPromedio(calificaciones);

        string resultado = (promedio >= 70) ? "Aprobado" : "No Aprobado";

        Console.WriteLine($"Matrícula: {matricula}");
        Console.WriteLine($"Promedio: {promedio:F2}");
        Console.WriteLine($"Resultado: {resultado}");
    }

    static string LeerMatricula(string mensaje)
    {
        string matricula;
        while (true)
        {
            Console.Write(mensaje);
            matricula = Console.ReadLine();
            if (long.TryParse(matricula, out long _)) 
                return matricula; 
            Console.WriteLine("Error: La matrícula debe ser solo numérica.");
        }
    }

    static double LeerCalificacion(string mensaje)
    {
        double calificacion;
        while (true)
        {
            Console.Write(mensaje);
            if (double.TryParse(Console.ReadLine(), out calificacion) && calificacion >= 0 && calificacion <= 100)
                return calificacion; 
            Console.WriteLine("Error: Ingrese una calificación válida entre 0 y 100.");
        }
    }

    static double CalcularPromedio(double[] calificaciones)
    {
        double suma = 0;
        foreach (double calificacion in calificaciones)
        {
            suma += calificacion;
        }
        return suma / calificaciones.Length;
    }
}
