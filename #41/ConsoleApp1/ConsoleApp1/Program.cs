using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cálculo de deducción al seguro social.");

        string estadoCivil = LeerEstadoCivil("Ingrese su estado civil (soltero/casado): ");

        bool tieneHijos = false;
        if (estadoCivil == "casado")
        {
            tieneHijos = LeerTieneHijos("¿Tiene hijos? (si/no): ");
        }

        double salario = LeerSalario("Ingrese su salario mensual: ");

        double deduccion = CalcularDeduccion(salario, estadoCivil, tieneHijos);

        Console.WriteLine($"Salario: C$ {salario:C}");
        Console.WriteLine($"Deducción al seguro social: C$ {deduccion:C}");
    }

    static string LeerEstadoCivil(string mensaje)
    {
        string estadoCivil;
        while (true)
        {
            Console.Write(mensaje);
            estadoCivil = Console.ReadLine().ToLower();
            if (estadoCivil == "soltero" || estadoCivil == "casado")
                return estadoCivil;
            Console.WriteLine("Error: Ingrese 'soltero' o 'casado'.");
        }
    }

    static bool LeerTieneHijos(string mensaje)
    {
        string respuesta;
        while (true)
        {
            Console.Write(mensaje);
            respuesta = Console.ReadLine().ToLower();
            if (respuesta == "si")
                return true; 
            else if (respuesta == "no")
                return false; 
            Console.WriteLine("Error: Ingrese 'si' o 'no'.");
        }
    }

    static double LeerSalario(string mensaje)
    {
        double salario;
        while (true)
        {
            Console.Write(mensaje);
            if (double.TryParse(Console.ReadLine(), out salario) && salario >= 0)
                return salario; 
            Console.WriteLine("Error: Ingrese un valor válido para el salario (número positivo).");
        }
    }

    static double CalcularDeduccion(double salario, string estadoCivil, bool tieneHijos)
    {
        double porcentajeDeduccion = 0;

        if (estadoCivil == "soltero")
        {
            porcentajeDeduccion = 0.01; 
        }
        else if (estadoCivil == "casado")
        {
            if (tieneHijos)
            {
                porcentajeDeduccion = 0.03; 
            }
            else
            {
                porcentajeDeduccion = 0.02; 
            }
        }

        return salario * porcentajeDeduccion; 
    }
}

