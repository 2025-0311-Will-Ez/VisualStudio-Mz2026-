Console.Write("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine());

if (edad >= 18)
{
    Console.WriteLine("Bienvenido. Acceso permitido.");
}
else
{
    Console.WriteLine("Acceso denegado. Debe ser mayor de edad.");
}

Console.ReadKey();