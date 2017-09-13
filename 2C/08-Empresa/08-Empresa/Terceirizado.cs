using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Terceirizado : Empregado
    {
        public string empresaM { get; set; }
        
        public Terceirizado(string empresaM, string gerente, string nome) : base(gerente, nome)
        {
            this.empresaM = empresaM;
        }
    }
}
