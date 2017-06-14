using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número");
            string numStr = Console.ReadLine();

            Console.WriteLine(IntParse(numStr));
        }

        public static int IntParse(string numroIng)
        {
            int multi = 1;
            int numero = 0;

            for (int i = numroIng.Length - 1; i >= 0; i--)
            {
                numero = numero + (numroIng[i] - '0') * multi;
                multi = multi * 10;
            }
            return numero;
        }
    }
}
