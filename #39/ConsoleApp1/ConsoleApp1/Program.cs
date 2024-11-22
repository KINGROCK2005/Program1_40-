using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        double total;
        Console.WriteLine("Cálculo de comisión por ventas mensuales.");

        double ventaTotal = LeerVentaTotal("Ingrese el total de ventas mensuales: ");

        double comision = CalcularComision(ventaTotal);

        Console.WriteLine($"Venta total: C$ {ventaTotal:C}");
        Console.WriteLine($"Comisión: C$ {comision:C}");
        total = ventaTotal + comision;
        Console.WriteLine($"Total {total:C}");

    }

    static double LeerVentaTotal(string mensaje)
    {
        double ventaTotal;
        while (true)
        {
            Console.Write(mensaje);
            if (double.TryParse(Console.ReadLine(), out ventaTotal) && ventaTotal >= 0)
                return ventaTotal; 
            Console.WriteLine("Error: Ingrese un valor válido para las ventas (número positivo).");
        }
    }

    static double CalcularComision(double ventaTotal)
    {
        double comisionPorcentaje;

        if (ventaTotal >= 10000) 
            comisionPorcentaje = 0.10; 
        else
            comisionPorcentaje = 0.05; 

        return ventaTotal * comisionPorcentaje;
        
    }
    

}

