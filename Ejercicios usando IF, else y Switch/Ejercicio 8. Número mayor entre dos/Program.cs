using System;

class Program
{
    static void Main()
    {
        Console.Write("Primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
            Console.WriteLine("El mayor es: " + num1);
        else if (num2 > num1)
            Console.WriteLine("El mayor es: " + num2);
        else
            Console.WriteLine("Los números son iguales");
    }
}