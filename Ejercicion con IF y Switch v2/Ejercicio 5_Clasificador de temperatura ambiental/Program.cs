Console.Write("Ingrese la temperatura: ");
double temperatura = double.Parse(Console.ReadLine());

if (temperatura < 15)
{
    Console.WriteLine("Clima Frío");
}
else if (temperatura <= 28)
{
    Console.WriteLine("Clima Templado");
}
else
{
    Console.WriteLine("Clima Cálido");
}

Console.ReadKey();