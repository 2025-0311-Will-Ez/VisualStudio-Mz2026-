using System;

class Program
{
    static void Main()
    {
        Console.Write("Primer número: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Segundo número: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Tercer número: ");
        int c = int.Parse(Console.ReadLine());

        if (a > 0 && b > 0 && c > 0)
            Console.WriteLine("Todos positivos");
        else if (a < 0 && b < 0 && c < 0)
            Console.WriteLine("Todos negativos");
        else if (a == 0 || b == 0 || c == 0)
            Console.WriteLine("Hay ceros");
        else
            Console.WriteLine("Mixtos");
    }
}