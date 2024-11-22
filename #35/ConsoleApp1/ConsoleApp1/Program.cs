using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cálculo del salario bruto del empleado.");

        double sueldoPorHora = LeerSueldoPorHora("Ingrese el sueldo por hora del empleado: ");

        int horasTrabajadas = LeerHorasTrabajadas("Ingrese el número de horas trabajadas: ");

        double salarioBruto = CalcularSalarioBruto(sueldoPorHora, horasTrabajadas);

        Console.WriteLine($"El salario bruto del empleado es: {salarioBruto:C}");
    }

    static double LeerSueldoPorHora(string mensaje)
    {
        double sueldo;
        while (true)
        {
            Console.Write(mensaje);
            if (double.TryParse(Console.ReadLine(), out sueldo) && sueldo > 0)
                return sueldo; 
            Console.WriteLine("Error: Ingrese un sueldo válido mayor a 0.");
        }
    }

    static int LeerHorasTrabajadas(string mensaje)
    {
        int horas;
        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out horas) && horas >= 0)
                return horas; 
            Console.WriteLine("Error: Ingrese un número de horas válido (mayor o igual a 0).");
        }
    }

    static double CalcularSalarioBruto(double sueldoPorHora, int horasTrabajadas)
    {
        return sueldoPorHora * horasTrabajadas;
    }
}

