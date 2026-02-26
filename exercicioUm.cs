using System;
using System.Globalization;

namespace exercicioUm
{
    internal class exercicioUm
    {
        static void Main(string[] args)
        {

            double x1, y1, x2, y2, distancia;

            Console.WriteLine("Digite as coordenadas do ponto x1:");
            x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite as coordenadas do ponto y1:");
            y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite as coordenadas do ponto x2:");
            x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite as coordenadas do ponto y2:");
            y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}

