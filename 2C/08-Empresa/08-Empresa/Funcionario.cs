using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Funcionario
    {
        public string nome, email;
        public double salario;
        private int nroRegistro, cpf;

        public int NroRegistro
        {
            get { return this.nroRegistro; }

        }

        public int CPF
        {
            get { return this.cpf; }
        }

        public Funcionario (string nome)
        {
            this.nome = nome;
        }
    }
}
