using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cálculo de salario de un trabajador.");

        double salarioPorHora = LeerSalarioPorHora("Ingrese el salario por hora del trabajador: ");

        int horasTrabajadas = LeerHorasTrabajadas("Ingrese las horas trabajadas: ");

        double salarioTotal = CalcularSalario(salarioPorHora, horasTrabajadas);

        Console.WriteLine($"El salario total del trabajador es: {salarioTotal:C}");
    }

    static double LeerSalarioPorHora(string mensaje)
    {
        double salario;
        while (true)
        {
            Console.Write(mensaje);
            if (double.TryParse(Console.ReadLine(), out salario) && salario > 0)
                return salario; 
            Console.WriteLine("Error: Ingrese un salario válido mayor a 0.");
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

    static double CalcularSalario(double salarioPorHora, int horasTrabajadas)
    {
        double salarioTotal;

        if (horasTrabajadas <= 30)
        {
            salarioTotal = salarioPorHora * horasTrabajadas;
        }
        else
        {
            salarioTotal = salarioPorHora * 30;
            salarioTotal += (horasTrabajadas - 30) * salarioPorHora * 1.5;
        }

        return salarioTotal;
    }
}

