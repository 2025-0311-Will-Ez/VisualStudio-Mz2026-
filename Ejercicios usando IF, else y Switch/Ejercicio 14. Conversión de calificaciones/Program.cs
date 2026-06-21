using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la calificación (0-100): ");
        int nota = int.Parse(Console.ReadLine());

        if (nota >= 90)
            Console.WriteLine("A");
        else if (nota >= 80)
            Console.WriteLine("B");
        else if (nota >= 70)
            Console.WriteLine("C");
        else if (nota >= 60)
            Console.WriteLine("D");
        else
            Console.WriteLine("F");
    }
}