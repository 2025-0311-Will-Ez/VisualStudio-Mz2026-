Console.Write("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("Número Par");
}
else
{
    Console.WriteLine("Número Impar");
}

Console.ReadKey();