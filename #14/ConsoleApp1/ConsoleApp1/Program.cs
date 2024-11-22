using System;

namespace Empleados
{
    class Program
    {
        const double INSS_RATE = 0.0625;
        const double IR_THRESHOLD = 8000.0; 
        const double IR_RATE = 0.15;        

        static void Main(string[] args)
        {
            string[] nombres = new string[5];
            double[] salarios = new double[5];
            double[] inss = new double[5];
            double[] ir = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nEmpleado {i + 1}:");

                Console.Write("Ingrese el nombre del empleado: ");
                nombres[i] = Console.ReadLine().Trim();
                while (string.IsNullOrWhiteSpace(nombres[i]))
                {
                    Console.WriteLine("Error: el nombre no puede estar vacío.");
                    Console.Write("Ingrese el nombre del empleado: ");
                    nombres[i] = Console.ReadLine().Trim();
                }

                bool salarioValido = false;
                while (!salarioValido)
                {
                    Console.Write($"Ingrese el salario de {nombres[i]} en córdobas: ");
                    if (double.TryParse(Console.ReadLine(), out salarios[i]) && salarios[i] > 0)
                    {
                        salarioValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Error: ingrese un número válido y positivo para el salario.");
                    }
                }

                inss[i] = CalcularInss(salarios[i]);
                ir[i] = CalcularIr(salarios[i]);
            }

            Console.WriteLine("\nResumen de empleados:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Empleado: {nombres[i]}");
                Console.WriteLine($"Salario: C${salarios[i]:F2}");
                Console.WriteLine($"INSS (6.25%): C${inss[i]:F2}");
                if (salarios[i] > IR_THRESHOLD)
                {
                    Console.WriteLine($"IR (15% sobre salario > C$8000): C${ir[i]:F2}");
                }
                else
                {
                    Console.WriteLine("IR: No aplica");
                }
                Console.WriteLine(new string('-', 30));
            }
        }

        static double CalcularInss(double salario)
        {
            return salario * INSS_RATE;
        }

        static double CalcularIr(double salario)
        {
            if (salario > IR_THRESHOLD)
            {
                return salario * IR_RATE;
            }
            return 0.0;
        }
    }
}
