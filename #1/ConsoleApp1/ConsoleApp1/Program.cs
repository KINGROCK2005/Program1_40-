using System;

namespace Tarea
{
    public class Salario
    {
        public static void Main()
        {

            string empleado;
            double hrstraba, pagBru, INSS, total;

            Console.WriteLine("Ingrese el nombre del trabajador");
            empleado = Console.ReadLine();

            Console.WriteLine("Ingrese las horas trabajadas;");
            hrstraba = int.Parse(Console.ReadLine());

            pagBru = hrstraba * 50;
            if (pagBru >= 2400)
            {
                INSS = pagBru + 84;
            }
            else
            {
                INSS = pagBru * 3.5;
            }
            total = pagBru + INSS;

            Console.WriteLine("El trabajador es:" + empleado);
            Console.WriteLine("Su salario es:" + total);



        }
    }
}