using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cálculo de colegiatura para estudiantes.");

        string tipoEstudiante = LeerTipoEstudiante("Ingrese el tipo de estudiante (veterano/regular): ");

        int numMaterias = LeerNumeroMaterias("Ingrese el número de materias a matricular: ");

        double costoColeg = CalcularCostoColeg(tipoEstudiante, numMaterias);

        if (tipoEstudiante.ToLower() == "veterano")
        {
            Console.WriteLine($"\nCategoría: VETERANO");
        }
        else
        {
            Console.WriteLine($"\nCategoría: REGULAR");
        }

        Console.WriteLine($"Número de materias inscritas: {numMaterias}");
        Console.WriteLine($"Costo total de colegiatura: C$ {costoColeg:C}");
    }

    static string LeerTipoEstudiante(string mensaje)
    {
        string tipo;
        while (true)
        {
            Console.Write(mensaje);
            tipo = Console.ReadLine().ToLower();
            if (tipo == "veterano" || tipo == "regular")
                return tipo; 
            Console.WriteLine("Error: Ingrese 'veterano' o 'regular'.");
        }
    }

    static int LeerNumeroMaterias(string mensaje)
    {
        int numMaterias;
        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out numMaterias) && numMaterias > 0)
                return numMaterias; 
            Console.WriteLine("Error: Ingrese un número válido de materias (mayor que 0).");
        }
    }

    static double CalcularCostoColeg(string tipoEstudiante, int numMaterias)
    {
        double costoPorMateria = tipoEstudiante == "veterano" ? 30 : 50;
        return costoPorMateria * numMaterias;
    }
}
