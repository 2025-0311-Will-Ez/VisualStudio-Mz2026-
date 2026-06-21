using System;

class Program
{
    static void Main()
    {
        Console.Write("Cantidad de notas: ");
        int n = int.Parse(Console.ReadLine());

        double suma = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Ingrese nota " + i + ": ");
            double nota = double.Parse(Console.ReadLine());
            suma += nota;
        }

        double promedio = suma / n;

        Console.WriteLine("Promedio final: " + promedio);
    }
}