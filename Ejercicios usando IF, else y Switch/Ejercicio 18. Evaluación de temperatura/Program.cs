using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la temperatura en °C: ");
        int temp = int.Parse(Console.ReadLine());

        if (temp < 0)
            Console.WriteLine("Hace mucho frío");
        else if (temp <= 20)
            Console.WriteLine("Clima fresco");
        else if (temp <= 30)
            Console.WriteLine("Clima agradable");
        else
            Console.WriteLine("Hace mucho calor");
    }
}