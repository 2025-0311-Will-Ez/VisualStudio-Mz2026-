using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su salario mensual: ");
        double salario = double.Parse(Console.ReadLine());

        if (salario < 10000)
            Console.WriteLine("Impuesto: 0%");
        else if (salario <= 30000)
            Console.WriteLine("Impuesto: 10%");
        else
            Console.WriteLine("Impuesto: 20%");
    }
}