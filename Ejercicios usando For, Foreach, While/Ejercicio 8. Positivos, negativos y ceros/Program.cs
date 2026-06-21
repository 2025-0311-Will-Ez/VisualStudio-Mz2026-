using System;

class Program
{
    static void Main()
    {
        Console.Write("Cantidad de números: ");
        int n = int.Parse(Console.ReadLine());

        int[] numeros = new int[n];

        int positivos = 0, negativos = 0, ceros = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Ingrese número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        foreach (int num in numeros)
        {
            if (num > 0)
                positivos++;
            else if (num < 0)
                negativos++;
            else
                ceros++;
        }

        Console.WriteLine("Positivos: " + positivos);
        Console.WriteLine("Negativos: " + negativos);
        Console.WriteLine("Ceros: " + ceros);
    }
}