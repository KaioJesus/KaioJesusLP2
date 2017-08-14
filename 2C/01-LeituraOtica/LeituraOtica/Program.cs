using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraOtica
{
    class Program
    {
        static void Main(string[] args)
        {
            int NúmeroQuestões, A, B, C, D, E;
            Char resposta;

            Console.WriteLine("Informe a quantidade de questões");
            NúmeroQuestões = int.Parse(Console.ReadLine());

            for (int i = 0; i < NúmeroQuestões; i++)
            {
                A = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());
                C = int.Parse(Console.ReadLine());
                D = int.Parse(Console.ReadLine());
                E = int.Parse(Console.ReadLine());

                if (A <= 100 && B > 155 && C > 155 && D > 155 && E > 155)
                {
                    resposta = 'A';
                    Console.WriteLine(resposta);
                }
                else if (A > 155 && B <= 100 && C > 155 && D > 155 && E > 155)
                {
                    resposta = 'B';
                    Console.WriteLine(resposta);
                }
                else if (A > 155 && B > 155 && C <= 100 && D > 155 && E > 155)
                {
                    resposta = 'C';
                    Console.WriteLine(resposta);

                }
                else if (A > 155 && B > 155 && C > 155 && D <= 100 && E > 155)
                {
                    resposta = 'D';
                    Console.WriteLine(resposta);
                }
                else if (A > 155 && B > 155 && C > 155 && D > 155 && E <= 100)
                {
                    resposta = 'E';
                    Console.WriteLine(resposta);
                }
                else
                {
                    resposta = '*';
                    Console.WriteLine(resposta);
                }
            }
        }
    }
}
