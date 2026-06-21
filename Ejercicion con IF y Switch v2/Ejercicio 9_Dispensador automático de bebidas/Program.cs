Console.WriteLine("1. Café");
Console.WriteLine("2. Té");
Console.WriteLine("3. Chocolate");
Console.WriteLine("4. Capuchino");
Console.WriteLine("5. Kola Real");

Console.Write("Seleccione una opción: ");
int bebida = int.Parse(Console.ReadLine());

switch (bebida)
{
    case 1:
        Console.WriteLine("Café - RD$50");
        break;

    case 2:
        Console.WriteLine("Té - RD$40");
        break;

    case 3:
        Console.WriteLine("Chocolate - RD$60");
        break;

    case 4:
        Console.WriteLine("Capuchino - RD$80");
        break;
    case 5:
        Console.WriteLine("Kola Real - RD$25");
        break;

    default:
        Console.WriteLine("Opción no disponible.");
        break;
}

Console.ReadKey();