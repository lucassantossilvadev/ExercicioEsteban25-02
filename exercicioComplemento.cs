using System;
using System.Globalization;

namespace exercicioComplemento
{
    internal class exercicioComplemento
    {
        static void Main(string[] args)
        {
            
            int A, B, C, soma, maior;

            Console.WriteLine("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            C = int.Parse(Console.ReadLine());

            soma = A + B + C;

            if (A > B && A > C)
            {
                maior = A;
            }
            else if (B > C)
            {
                maior = B;
            }
            else
            {
                maior = C;
            }

            Console.WriteLine("O maior valor é: " + maior);


            if (soma % 2 == 0)
            {
                Console.WriteLine("A soma dos números é par.");
            }
            else
            {
                Console.WriteLine("A soma dos números é ímpar.");
            }

        }
    }
}
