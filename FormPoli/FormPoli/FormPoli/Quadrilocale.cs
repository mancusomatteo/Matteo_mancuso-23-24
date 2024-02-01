using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPoli
{
    public class Quadrilocale : Edificio
    {
        public Quadrilocale() : base(4, 200, "quadrilocale")
        {

        }

        public override string ToString()
        {
            return "Quadrilocale";
        }
    }

}
