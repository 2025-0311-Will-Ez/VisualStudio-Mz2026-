using System;

class Program
{
    static void Main()
    {
        Console.Write("Cantidad de números: ");
        int n = int.Parse(Console.ReadLine());

        int[] numeros = new int[n];
        bool[] visitado = new bool[n];

        // Llenar arreglo
        for (int i = 0; i < n; i++)
        {
            Console.Write("Ingrese número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Contar frecuencia
        for (int i = 0; i < n; i++)
        {
            if (visitado[i])
                continue;

            int contador = 1;

            for (int j = i + 1; j < n; j++)
            {
                if (numeros[i] == numeros[j])
                {
                    contador++;
                    visitado[j] = true;
                }
            }

            Console.WriteLine(numeros[i] + " se repite " + contador + " veces");
        }
    }
}