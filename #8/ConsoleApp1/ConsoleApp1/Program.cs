using System;
using System.Data;

namespace tarea
{
    public class ejer7
    {
        public static void Main()
        {
            double precio=0, precioF=0;
            int mes=0;

            Console.WriteLine("Ingrese el precio del producto:");
            precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Escribe el numero correspondiente del mes ");
            mes=int.Parse(Console.ReadLine());

            if(mes == 8)
            {
                precioF = precio + (precio * 0.15);

            }
            else 
            {
                precioF = precio;

                }
           Console.WriteLine("El precio final es: " + precioF);

        }
        
    }
}
