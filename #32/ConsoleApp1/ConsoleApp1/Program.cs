using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Verificación de signos de dos números.");

        int numero1 = LeerEntero("Ingrese el primer número: ");
        int numero2 = LeerEntero("Ingrese el segundo número: ");

        if ((numero1 > 0 && numero2 < 0) || (numero1 < 0 && numero2 > 0))
        {
            Console.WriteLine("SIGNOS OPUESTOS");
        }
        else
        {
            Console.WriteLine("SIGNOS IGUALES");
        }
    }

    static int LeerEntero(string mensaje)
    {
        int numero;
        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out numero))
                return numero; 
            Console.WriteLine("Error: Ingrese un número entero válido.");
        }
    }
}
