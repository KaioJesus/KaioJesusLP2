using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinal_LP2
{
    class Cliente
    {
        SqlCommand cmd = new SqlCommand()
        {
            Connection = new SqlConnection(@"Data Source=(localdb)\lptrab;Initial Catalog=Farmacia;Integrated Security=SSPI")
        };

        public void CadastroCliente()
        {
            Console.WriteLine("Informe o nome do cliente");
            Console.WriteLine("Informe o endereço do cliente");
            Console.WriteLine("Informe a data do pedido do cliente");
            Console.WriteLine("informe o produto solicitado pelo cliente");
        }
    }
}
