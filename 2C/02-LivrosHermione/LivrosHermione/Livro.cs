using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrosHermione
{
    class Livro
    {
        public string titulo;
        public int nropags, diarest;

        public int CalcTemp(int pghr, int hrdia)
        {
            return nropags / (pghr * hrdia);
        }

    }
}
