using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
            Console.WriteLine("Positivo");
        else if (num < 0)
            Console.WriteLine("Negativo");
        else
            Console.WriteLine("Cero");
    }
}