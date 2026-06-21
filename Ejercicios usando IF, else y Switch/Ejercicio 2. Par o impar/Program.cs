using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine("Par");
        else
            Console.WriteLine("Impar");
    }
}