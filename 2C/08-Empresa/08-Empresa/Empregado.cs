
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Empregado : Funcionario
    {
        public string gerente { get; set; }
        public int data { get; set; }

        public Empregado(string gerente, string nome) : base(nome)
        {
            this.gerente = gerente;
        }
    }

}
