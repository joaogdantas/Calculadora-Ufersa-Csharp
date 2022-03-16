using System;

namespace calculadoraufersa
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1 = 0;
            float nota2 = 0;
            float nota3 = 0;

            Console.WriteLine("\nColoque sua primeira nota");
            nota1 = float.Parse(Console.ReadLine() ?? "0");
            do
            {
                if (nota1 < 0 || nota1 > 10)
                {
                    Console.WriteLine("Nota Inválida, insira sua primeira nota");
                    nota1 = float.Parse(Console.ReadLine() ?? "0");
                }
                else {continue;}
            } while (nota1 < 0 || nota1 > 10);

            Console.WriteLine("\nColoque sua segunda nota");
            nota2 = float.Parse(Console.ReadLine() ?? "0");
            do
            {
                if (nota2 < 0 || nota2 > 10)
                {
                    Console.WriteLine("Nota Inválida, insira sua segunda nota");
                    nota2 = float.Parse(Console.ReadLine() ?? "0");
                }
                else {continue;}
            } while (nota2 < 0 || nota2 > 10);
            
            Console.WriteLine("\nColoque sua terceira nota");
            nota3 = float.Parse(Console.ReadLine() ?? "0");
            do
            {
                if (nota3 < 0 || nota3 > 10)
                {
                    Console.WriteLine("Nota Inválida, insira sua segunda nota");
                    nota3 = float.Parse(Console.ReadLine() ?? "0");
                }
                else {continue;}
            } while (nota3 < 0 || nota3 > 10);
            
            float mp = ((nota1 + nota2 + nota3)/3);
            float af = ((50-6*mp)/4);

            if (mp < 3.45)
            {
                Console.WriteLine("Você não atingiu a média necessária e foi reprovado. Sinto muito :(");
            }
            else if (mp >= 3.45 || mp < 6.95)
            {
                Console.WriteLine("Você não atingiu a média para passar por média e terá que fazer a quarta prova.\n");
                Console.WriteLine("A nota que você precisa na quarta prova é: " + af);
            }
            else
            {
                Console.WriteLine("Você passou!");
            }
        }
    }
}