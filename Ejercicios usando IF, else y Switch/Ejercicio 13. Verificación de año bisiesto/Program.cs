using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un año: ");
        int año = int.Parse(Console.ReadLine());

        if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
            Console.WriteLine("Es bisiesto");
        else
            Console.WriteLine("No es bisiesto");
    }
}