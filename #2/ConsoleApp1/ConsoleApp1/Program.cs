using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    internal class Variables
    {
        public static void Main()
        {
            int varA, varAF, varB, varBF;

            Console.WriteLine("Ingrese la variable a");
            varA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la variable b");
            varB = int.Parse(Console.ReadLine());

            varAF = varB + (varA * 0);
            varBF = varA + (varB * 0);

            Console.WriteLine("Nueva variable a:" + varAF);
            Console.WriteLine("Nueva variable b:" + varBF);

        }
    }
}