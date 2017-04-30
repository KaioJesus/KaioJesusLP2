using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        struct veiculo
        {
            public string modelo;
            public double km, potencia;
        }

        static void Main(string[] args)
        {
            veiculo automovel;
            int N, i;

            Console.WriteLine("Informe a quantidade de carros no galpão");
            N = Convert.ToInt32(Console.ReadLine());


            string[] valor = new string[N];

            for (i = 0; i < N; i++)
            {
                Console.WriteLine("Informe o modelo");
                automovel.modelo = Console.ReadLine();

                Console.WriteLine("Informe sua quilometragem");
                automovel.km = Double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a potência do motor");
                automovel.potencia = Double.Parse(Console.ReadLine());

                valor[i] = Carro(automovel);

            }

            for (i = 0; i < N; i++)
            {
                Console.WriteLine("{0}", valor);
            }
        }
        static string Carro(veiculo parametro)
        {
            string brabo, tiponsv, tipopfp;

            if (parametro.km <= 5000)
            {
                tiponsv = "novo";
            }
            else if (parametro.km > 5000 && parametro.km <= 30000)
            {
                tiponsv = "seminovo";
            }
            else
            {
                tiponsv = "velho";
            }

            if (parametro.potencia > 200)
            {
                tipopfp = "potente";
            }
            else if (parametro.potencia >= 120 && parametro.potencia <= 200)
            {
                tipopfp = "forte";
            }
            else
            {
                tipopfp = "popular";
            }

            brabo = parametro.modelo + " - " + tipopfp + " - " + tiponsv;
            return brabo;
        }


    }
}