using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese los datos de tres personas.\n");

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Persona {i}:");
            string nombre = LeerTexto("Nombre: ");
            string apellido = LeerTexto("Apellido: ");
            double salario = LeerSalario("Salario: ");
            Console.WriteLine($"Datos registrados - Nombre: {nombre} {apellido}, Salario: {salario:C}\n");
        }
    }

    static string LeerTexto(string mensaje)
    {
        string entrada;
        while (true)
        {
            Console.Write(mensaje);
            entrada = Console.ReadLine()?.Trim();
            if (!string.IsNullOrEmpty(entrada) && entrada.Length >= 2)
            {
                return entrada; 
            }
            Console.WriteLine("Error: Debe ingresar al menos 2 caracteres.");
        }
    }

    static double LeerSalario(string mensaje)
    {
        double salario;
        while (true)
        {
            Console.Write(mensaje);
            if (double.TryParse(Console.ReadLine(), out salario) && salario > 0)
            {
                return salario;
            }
            Console.WriteLine("Error: Ingrese un salario válido y mayor a 0.");
        }
    }
}

