using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrosHermione
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, devolver;
            Console.WriteLine("informe qntos livros ela lerá");
            n = int.Parse(Console.ReadLine());

            Livro[] livros = new Livro[n];

            for (int i = 0; i < n; i++)
            {
                livros[i] = new Livro();

                Console.WriteLine("Informe o nome do Livro");
                livros[i].titulo = Console.ReadLine();

                Console.WriteLine("Informe a quantidade de páginas");
                livros[i].nropags = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe os dias restantes para devolver o livro");
                livros[i].diarest = int.Parse(Console.ReadLine());

                devolver = livros[i].diarest - livros[i].CalcTemp(30, 5);
                Console.WriteLine("Tem {0} dias para devolver", devolver);

                if (devolver <= 0)                                    
                    Console.WriteLine("O livro {0} é impossivel de ler neste tempo", livros[i].titulo);
                
                else
                    Console.WriteLine("Entregue '{0}' logo", livros[i].titulo);
            }
        }
    }
}
