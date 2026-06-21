using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 5, 12, 7, 20, 33, 9 };

        Console.Write("Ingrese número a buscar: ");
        int buscar = int.Parse(Console.ReadLine());

        bool encontrado = false;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscar)
            {
                Console.WriteLine("Número encontrado en posición: " + i);
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Número no encontrado");
        }
    }
}