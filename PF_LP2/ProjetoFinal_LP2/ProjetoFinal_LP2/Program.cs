using System;

namespace ProjetoFinal_LP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O que deseja fazer: 1 - Cadastrar Produto || 2 - Cadastrar Cliente");
            int opcoes = int.Parse(Console.ReadLine());

            Produto pdt = new Produto();
            Cliente Clt = new Cliente();
            if(opcoes == 1)
            {
                pdt.CadastroProduto();
                            
            }
            else if (opcoes == 2)
            {
                Clt.CadastroCliente();
            }
          
        }
    }

}
