Console.Write("Ingrese su saldo: ");
double saldo = double.Parse(Console.ReadLine());

Console.Write("Ingrese el monto a retirar: ");
double retiro = double.Parse(Console.ReadLine());

if (saldo >= retiro)
{
    saldo = saldo - retiro;

    Console.WriteLine("Retiro realizado correctamente.");
    Console.WriteLine("Saldo restante: " + saldo);
}
else
{
    Console.WriteLine("Fondos insuficientes.");
}

Console.ReadKey();