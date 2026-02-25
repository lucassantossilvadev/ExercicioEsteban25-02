using System;
using System.Globalization;

namespace exercicioQuatro
{
    internal class exercicioQuatro
    {
        static void Main(string[] args)
        {
            
            double numero;

            Console.WriteLine("Digite um número inteiro:");
            numero = double.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }

            Console.ReadLine();

        }
    }
}
