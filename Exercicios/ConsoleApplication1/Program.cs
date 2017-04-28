using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            string modelo, valor;
            double km, pot;

            Console.WriteLine("Informe a quantidade de carros no galpão");
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Informe o modelo do carro");
                modelo = Console.ReadLine();

                Console.WriteLine("Informe a quilometragem do carro");
                km = Double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a potência do motor do carro");
                pot = Double.Parse(Console.ReadLine());

                valor = Carro(modelo, km, pot);

                Console.WriteLine("{0}", valor);
            }
        }
            string Carro(string mode, double kmt, double pote)
            {
                string brabo, tiponsv, tipopfp;

                if (kmt <= 5000)
                {
                    tiponsv = "novo";
                }
                else if (kmt > 5000 && kmt <= 30000)
                {
                    tiponsv = "seminovo";
                }
                else
                {
                    tiponsv = "velho";
                }

                if (pote > 200)
                {
                    tipopfp = "potente";
                }
                else if (pote >= 120 && pote <= 200)
                {
                    tipopfp = "forte";
                }
                else
                {
                    tipopfp = "popular";
                }

                brabo = mode + " - " + tipod + " - " + tiponsv;
                return brabo;
            
            }
    }
}
