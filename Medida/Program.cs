﻿using Medida;
using System;
using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (x.A + x.B + x.C) / 2;

            double areaX = Math.Sqrt(pX* (pX - x.A) * (pX - x.B) * (pX - x.C));

            double pY = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(pY * (pY - y.A) * (pY- y.B) * (pY - y.C));

            Console.WriteLine($"A area de X é: {areaX}");
            Console.WriteLine($"A area de Y é: {areaY}");

            if (areaX > areaY)
                Console.WriteLine("A area X é maior");

            else
                Console.WriteLine("A area Y é maior");

        }
    }
}
