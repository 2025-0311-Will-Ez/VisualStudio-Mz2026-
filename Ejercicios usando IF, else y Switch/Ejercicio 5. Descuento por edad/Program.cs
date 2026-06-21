using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad > 60)
            Console.WriteLine("Aplica 50% de descuento");
        else
            Console.WriteLine("No aplica descuento");
    }
}