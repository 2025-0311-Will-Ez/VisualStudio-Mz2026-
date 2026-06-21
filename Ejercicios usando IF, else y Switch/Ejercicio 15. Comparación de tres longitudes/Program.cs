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

        if ((a + b > c) && (a + c > b) && (b + c > a))
            Console.WriteLine("Sí pueden formar un triángulo");
        else
            Console.WriteLine("No pueden formar un triángulo");
    }
}