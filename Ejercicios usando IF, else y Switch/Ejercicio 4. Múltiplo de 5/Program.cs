using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 5 == 0)
            Console.WriteLine("Es múltiplo de 5");
        else
            Console.WriteLine("No es múltiplo de 5");
    }
}