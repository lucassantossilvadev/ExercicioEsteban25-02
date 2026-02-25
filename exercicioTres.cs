using System;
using System.Globalization;

namespace exercicioTres
{
    internal class exercicioTres
    {
        static void Main(string[] args)
        {
            
            double notaUm, notaDois, notaTres, media;

            Console.WriteLine("Digite a primeira nota do aluno: ");
            notaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
            Console.WriteLine("Digite a segunda nota do aluno: ");
            notaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a terceira nota do aluno: ");
            notaTres = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            notaUm = notaUm * 2;
            notaDois = notaDois * 3;
            notaTres = notaTres * 5;

            media = (notaUm + notaDois + notaTres) / 10;

            Console.WriteLine("A média do aluno é: " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
