using System;
using System.Collections.Generic;

namespace Menu
{
    class Program
    {
        static List<string> factura = new List<string>();
        static double total = 0;

        static void Main()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();

                Console.WriteLine("Bienvenidos a nuestra heladería Los Frozonos\n");

                Console.WriteLine("===== CATEGORÍAS =====\n");
                Console.WriteLine("1. Normales");
                Console.WriteLine("2. Naturales");
                Console.WriteLine("3. Yoguen");
                Console.WriteLine("4. Ver Factura");
                Console.WriteLine("5. Salir");
                Console.Write("\nSeleccione una opción: ");

                int opcion;

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida.");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Normales();
                        break;

                    case 2:
                        Naturales();
                        break;

                    case 3:
                        Yoguen();
                        break;

                    case 4:
                        MostrarFactura();
                        break;

                    case 5:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void Normales()
        {
            Console.Clear();

            Console.WriteLine("===== NORMALES =====");
            Console.WriteLine("1. Chocolate - $50");
            Console.WriteLine("2. Fresa - $30");
            Console.WriteLine("3. Vainilla - $40");
            Console.WriteLine("4. Ciruela - $55");
            Console.WriteLine("5. Oreo - $65");
            Console.WriteLine("6. Bizcocho - $45");
            Console.WriteLine("7. ChocoManí - $75");
            Console.WriteLine("8. Menta - $20");
            Console.WriteLine("0. Volver");

            Console.Write("\nSeleccione un producto: ");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
                return;

            switch (opcion)
            {
                case 1:
                    factura.Add("Chocolate - $50");
                    total += 50;
                    break;

                case 2:
                    factura.Add("Fresa - $30");
                    total += 30;
                    break;

                case 3:
                    factura.Add("Vainilla - $40");
                    total += 40;
                    break;

                case 4:
                    factura.Add("Ciruela - $55");
                    total += 55;
                    break;

                case 5:
                    factura.Add("Oreo - $65");
                    total += 65;
                    break;

                case 6:
                    factura.Add("Bizcocho - $45");
                    total += 45;
                    break;

                case 7:
                    factura.Add("ChocoManí - $75");
                    total += 75;
                    break;

                case 8:
                    factura.Add("Menta - $20");
                    total += 20;
                    break;
            }
        }

        static void Naturales()
        {
            Console.Clear();

            Console.WriteLine("===== NATURALES =====");
            Console.WriteLine("1. Almendra - $50");
            Console.WriteLine("2. Coco - $45");
            Console.WriteLine("3. Avena - $30");
            Console.WriteLine("4. Soya - $25");
            Console.WriteLine("5. Frutos Rojos - $50");
            Console.WriteLine("6. Limón - $70");
            Console.WriteLine("7. Mango - $55");
            Console.WriteLine("8. Batata - $25");
            Console.WriteLine("9. Lechoza - $45");
            Console.WriteLine("10. Chinola - $80");
            Console.WriteLine("0. Volver");

            Console.Write("\nSeleccione un producto: ");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
                return;

            switch (opcion)
            {
                case 1: factura.Add("Almendra - $50"); total += 50; break;
                case 2: factura.Add("Coco - $45"); total += 45; break;
                case 3: factura.Add("Avena - $30"); total += 30; break;
                case 4: factura.Add("Soya - $25"); total += 25; break;
                case 5: factura.Add("Frutos Rojos - $50"); total += 50; break;
                case 6: factura.Add("Limón - $70"); total += 70; break;
                case 7: factura.Add("Mango - $55"); total += 55; break;
                case 8: factura.Add("Batata - $25"); total += 25; break;
                case 9: factura.Add("Lechoza - $45"); total += 45; break;
                case 10: factura.Add("Chinola - $80"); total += 80; break;
            }
        }

        static void Yoguen()
        {
            Console.Clear();

            Console.WriteLine("===== YOGUEN =====");
            Console.WriteLine("1. Granola - $70");
            Console.WriteLine("2. Caramelo - $75");
            Console.WriteLine("3. Sencillo - $60");
            Console.WriteLine("4. Frambuesa - $65");
            Console.WriteLine("5. Chispas de Chocolate - $75");
            Console.WriteLine("6. Almendras - $80");
            Console.WriteLine("7. Cereal - $65");
            Console.WriteLine("8. Pistacho - $70");
            Console.WriteLine("9. Turrón - $90");
            Console.WriteLine("0. Volver");

            Console.Write("\nSeleccione un producto: ");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
                return;

            switch (opcion)
            {
                case 1: factura.Add("Granola - $70"); total += 70; break;
                case 2: factura.Add("Caramelo - $75"); total += 75; break;
                case 3: factura.Add("Sencillo - $60"); total += 60; break;
                case 4: factura.Add("Frambuesa - $65"); total += 65; break;
                case 5: factura.Add("Chispas de Chocolate - $75"); total += 75; break;
                case 6: factura.Add("Almendras - $80"); total += 80; break;
                case 7: factura.Add("Cereal - $65"); total += 65; break;
                case 8: factura.Add("Pistacho - $70"); total += 70; break;
                case 9: factura.Add("Turrón - $90"); total += 90; break;
            }
        }

        static void MostrarFactura()
        {
            Console.Clear();

            Console.WriteLine("===== FACTURA =====\n");

            if (factura.Count == 0)
            {
                Console.WriteLine("No hay productos agregados.");
            }
            else
            {
                foreach (string item in factura)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("\n-------------------");
                Console.WriteLine($"TOTAL: ${total}");
            }

            Console.WriteLine("\nPresione una tecla para volver...");
            Console.ReadKey();
        }
    }
}