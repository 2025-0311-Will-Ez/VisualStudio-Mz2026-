using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la hora (0-23): ");
        int hora = int.Parse(Console.ReadLine());

        if (hora >= 6 && hora <= 11)
            Console.WriteLine("Mañana");
        else if (hora >= 12 && hora <= 17)
            Console.WriteLine("Tarde");
        else if (hora >= 18 && hora <= 23)
            Console.WriteLine("Noche");
        else if (hora >= 0 && hora <= 5)
            Console.WriteLine("Madrugada");
        else
            Console.WriteLine("Hora inválida");
    }
}