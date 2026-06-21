using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el precio del producto: ");
        double precio = double.Parse(Console.ReadLine());

        double descuento = 0;

        if (precio < 50)
            descuento = 0;
        else if (precio <= 100)
            descuento = 0.05;
        else
            descuento = 0.10;

        double precioFinal = precio - (precio * descuento);

        Console.WriteLine("Precio final: $" + precioFinal);
    }
}