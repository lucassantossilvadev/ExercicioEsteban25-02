using System;
using System.Globalization; 

namespace exercicioDois
{
    internal class exercicioDois
    {
        static void Main(string[] args)
        {
            int A, B, C;
            double D, R, S;

            Console.WriteLine("Digite os valores de A:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os valores de B:");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os valores de C:");
            C = int.Parse(Console.ReadLine());

            R = Math.Pow(A + B, 2.0);
            S = Math.Pow(B + C, 2.0);

            D = (R + S) / 2.0;

            Console.WriteLine("O valor de D é: " + D.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
