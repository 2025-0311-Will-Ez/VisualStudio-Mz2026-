Console.Write("Ingrese el nombre de un mes: ");
string mes = Console.ReadLine().ToLower();

switch (mes)
{
    case "diciembre":
    case "enero":
    case "febrero":
        Console.WriteLine("Invierno");
        break;

    case "marzo":
    case "abril":
    case "mayo":
        Console.WriteLine("Primavera");
        break;

    case "junio":
    case "julio":
    case "agosto":
        Console.WriteLine("Verano");
        break;

    case "septiembre":
    case "octubre":
    case "noviembre":
        Console.WriteLine("Otoño");
        break;

    default:
        Console.WriteLine("Mes inválido.");
        break;
}

Console.ReadKey();