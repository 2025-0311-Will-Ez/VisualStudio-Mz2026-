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

        int mayor = a;

        if (b > mayor)
            mayor = b;

        if (c > mayor)
            mayor = c;

        Console.WriteLine("El mayor es: " + mayor);
    }
}