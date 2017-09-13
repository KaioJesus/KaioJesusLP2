using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Gerente : Funcionario
    {
        public string setor { get; set; }
        public int bonus { get; set; }

        public Gerente(string setor, string nome) : base(nome)
        {
            this.setor = setor;

        }

    }
}
