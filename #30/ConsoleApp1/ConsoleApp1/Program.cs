using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cálculo de interés sobre un capital prestado.");

        double capital = LeerCapital("Ingrese el capital prestado en córdobas: ");
        double tasaInteres = capital > 10000 ? 0.07 : 0.06; 
        double interes = capital * tasaInteres; 

        Console.WriteLine($"\nCapital inicial: {capital:C}");
        Console.WriteLine($"Tasa de interés: {tasaInteres * 100}%");
        Console.WriteLine($"Interés acumulado en un año: {interes:C}");
    }

    static double LeerCapital(string mensaje)
    {
        double capital;
        while (true)
        {
            Console.Write(mensaje);
            if (double.TryParse(Console.ReadLine(), out capital) && capital > 0)
                return capital; 
            Console.WriteLine("Error: Ingrese un número positivo válido para el capital.");
        }
    }
}
