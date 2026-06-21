using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la calificación: ");
        int nota = int.Parse(Console.ReadLine());

        if (nota >= 60)
            Console.WriteLine("Aprobó");
        else
            Console.WriteLine("Reprobó");
    }
}