using System;

class Program
{
    public static void Main()
    {
        double baseTriangulo;
        double alturaTriangulo;
        bool esValidaBase, esValidaAltura;

        do
        {
            Console.Write("Ingrese la base del triángulo (número positivo): ");
            string entradaBase = Console.ReadLine();
            esValidaBase = double.TryParse(entradaBase, out baseTriangulo) && baseTriangulo > 0;

            if (!esValidaBase)
            {
                Console.WriteLine("Por favor, ingrese un número positivo válido para la base.");
            }
        } while (!esValidaBase);

        do
        {
            Console.Write("Ingrese la altura del triángulo (número positivo): ");
            string entradaAltura = Console.ReadLine();
            esValidaAltura = double.TryParse(entradaAltura, out alturaTriangulo) && alturaTriangulo > 0;

            if (!esValidaAltura)
            {
                Console.WriteLine("Por favor, ingrese un número positivo válido para la altura.");
            }
        } while (!esValidaAltura);

        double area = CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);

        Console.WriteLine("El área del triángulo es: " + area);
    }

    static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
    {
        return (baseTriangulo * alturaTriangulo) / 2;
    }
}

