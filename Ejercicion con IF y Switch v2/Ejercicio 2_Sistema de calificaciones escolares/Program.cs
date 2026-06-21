Console.Write("Ingrese la calificación: ");
int nota = int.Parse(Console.ReadLine());

if (nota >= 60)
{
    Console.WriteLine("Aprobado");
}
else
{
    Console.WriteLine("Reprobado");
}

Console.ReadKey();