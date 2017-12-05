using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Poderia informar, por gentileza, a marca do automóvel?");
            string a = Console.ReadLine();

            Console.WriteLine("Poderia informar, por gentileza, o modelo do automóvel?");
            string b = Console.ReadLine();

            Console.WriteLine("Poderia informar, por gentileza, a placa do automóvel?");
            string c = Console.ReadLine();

            Console.WriteLine("Poderia informar, por gentileza, a cor do automóvel?");
            string d = Console.ReadLine();

            Console.WriteLine("Poderia informar, por gentileza, a potência do automóvel?");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Poderia informar, por gentileza, o ano de fabricação do automóvel?");
            int f = int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection("Data Source=Jesus;Initial Catalog=Jesus;Integrated Security=SSPI"),
                CommandText =                   @"INSERT
                                                INTO Carro(Marca, Modelo, Placa, Cor, Potencia)
                                                VALUES(@Marca, @Modelo, @Placa, @Cor, @Potencia, @ano)"
            };

            cmd.Parameters.AddWithValue("Marca", a);
            cmd.Parameters.AddWithValue("Modelo", b);
            cmd.Parameters.AddWithValue("Placa", c);
            cmd.Parameters.AddWithValue("Cor", d);
            cmd.Parameters.AddWithValue("Potencia", e);
            cmd.Parameters.AddWithValue("Ano", f);

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

        /*    if (reader.HasRows)
            {
                while(reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string marca = reader.GetString(1);
                    string modelo = reader.GetString(2);
                    string placa = reader.GetString(3);
                    string cor = reader.GetString(4);
                    int potencia = reader.GetInt32(5);

                    Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5}", id, marca, modelo, placa, cor, potencia);
                }
            }  */
            cmd.Connection.Close();

            Console.WriteLine("Você é brabo!");
        }   
    } 
}
