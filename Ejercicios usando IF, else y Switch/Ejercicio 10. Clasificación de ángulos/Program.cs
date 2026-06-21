using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un ángulo: ");
        int angulo = int.Parse(Console.ReadLine());

        if (angulo < 90)
            Console.WriteLine("Ángulo agudo");
        else if (angulo == 90)
            Console.WriteLine("Ángulo recto");
        else if (angulo > 90 && angulo < 180)
            Console.WriteLine("Ángulo obtuso");
        else if (angulo == 180)
            Console.WriteLine("Ángulo llano");
        else
            Console.WriteLine("Ángulo no válido para esta clasificación");
    }
}