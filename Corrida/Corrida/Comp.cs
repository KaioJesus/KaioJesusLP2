using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corrida
{
    class Comp
    {                 
        public string nome;
        public double prim;
        public double seg;
        public double terc;

        public double temcalcular()
        {
            double temtudo = 0;

            if(prim > seg && prim > terc)
                temtudo = seg + terc;
            
            else if (seg > tec)
                temtudo = prim + terc;

            else
                temtudo = prim + seg;


            return temtudo;

            
        }
        
    }
}
