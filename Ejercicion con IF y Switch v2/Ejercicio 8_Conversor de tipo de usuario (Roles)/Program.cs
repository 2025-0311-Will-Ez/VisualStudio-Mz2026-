Console.Write("Ingrese el rol (A, E, O, L): ");
string rol = Console.ReadLine().ToUpper();

switch (rol)
{
    case "A":
        Console.WriteLine("Administrador: acceso total al sistema.");
        break;

    case "E":
        Console.WriteLine("Editor: puede modificar contenido.");
        break;

    case "O":
        Console.WriteLine("Autor: puede crear contenido.");
        break;

    case "L":
        Console.WriteLine("Lector: solo puede visualizar contenido.");
        break;

    default:
        Console.WriteLine("Invitado.");
        break;
}

Console.ReadKey();