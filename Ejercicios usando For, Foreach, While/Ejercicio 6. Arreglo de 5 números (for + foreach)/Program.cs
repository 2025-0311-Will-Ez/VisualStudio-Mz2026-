using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];

        // Llenar arreglo
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Ingrese número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Mostrar arreglo
        Console.WriteLine("Valores ingresados:");
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }
    }
}