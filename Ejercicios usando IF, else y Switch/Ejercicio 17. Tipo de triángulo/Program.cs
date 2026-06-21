using System;

class Program
{
    static void Main()
    {
        Console.Write("Lado 1: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Lado 2: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Lado 3: ");
        double c = double.Parse(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("Triángulo equilátero");
        else if (a == b || a == c || b == c)
            Console.WriteLine("Triángulo isósceles");
        else
            Console.WriteLine("Triángulo escaleno");
    }
}