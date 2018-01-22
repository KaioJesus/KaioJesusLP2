using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinal_LP2
{
    class Produto
    {
      

        SqlCommand cmd = new SqlCommand()
        {
            Connection = new SqlConnection(@"Data Source=(localdb)\lptrab;Initial Catalog=Farmacia;Integrated Security=SSPI")
        };

        public void CadastroProduto()
        {
            string a, d;
            int b;
            double c; 
            Console.WriteLine("Informe o nome do produto");
            a = Console.ReadLine();

            Console.WriteLine("Informe a validade do produto?");
            d = Console.ReadLine();

            Console.WriteLine("Informe a quantidade desse produto no estoque?");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço do produto");
            c = double.Parse(Console.ReadLine());

            cmd.commandText = String.Format(@"INSERT 
                                              INTO Drogaria(produto, quantidade, validade, preco)
                                              VALUES(@produto, @quantidade, @validade, @preco)");

         }                                   
        cmd.Parameters.AddWithValue()
        cmd.Parameters.AddWithValue()
        cmd.Parameters.AddWithValue()
        cmd.Parameters.AddWithValue()

        
    }
}
