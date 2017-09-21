using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConversorMedidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConversordeMedidas.GParaKg(1));
            Console.WriteLine(ConversordeMedidas.KgparaG(1));
            Console.WriteLine(ConversordeMedidas.KgparaT(1));
            Console.WriteLine(ConversordeMedidas.TparaKg(1));
            Console.WriteLine(ConversordeMedidas.KgparaLBS(1));
            Console.WriteLine(ConversordeMedidas.LBSparaKG(1));
            Console.WriteLine(ConversordeMedidas.TfparaTc(1));
            Console.WriteLine(ConversordeMedidas.TcparaTf(1));
            Console.WriteLine(ConversordeMedidas.TfparaTk(1));
            Console.WriteLine(ConversordeMedidas.TkparaTf(1));
            Console.WriteLine(ConversordeMedidas.TcparaTk(1));
            Console.WriteLine(ConversordeMedidas.TkparaTc(1));
            Console.WriteLine(ConversordeMedidas.MparaKm(1));
            Console.WriteLine(ConversordeMedidas.KmparaM(1));
            Console.WriteLine(ConversordeMedidas.KmparaMilha(1));
            Console.WriteLine(ConversordeMedidas.MilhaparaKm(1));
            Console.WriteLine(ConversordeMedidas.MparaPes(1));
            Console.WriteLine(ConversordeMedidas.PesparaM(1));
            Console.WriteLine(ConversordeMedidas.MparaPol(1));
            Console.WriteLine(ConversordeMedidas.PolparaM(1));
            Console.WriteLine(ConversordeMedidas.PolparaPes(1));
            Console.WriteLine(ConversordeMedidas.PesparaPol(1));
        }
    }
}
