using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Verificar si una persona es votante o no.");
        int edad = LeerEdad("Ingrese la edad de la persona: ");
        DeterminarVotante(edad);
    }

    static int LeerEdad(string mensaje)
    {
        int edad;
        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out edad) && edad > 0)
                return edad;
            Console.WriteLine("Error: Ingrese una edad válida mayor a 0.");
        }
    }

    static void DeterminarVotante(int edad)
    {
        if (edad >= 16)
        {
            Console.WriteLine("Puede votar.");
        }
        else
        {
            Console.WriteLine("No puede votar.");
        }
    }
}

