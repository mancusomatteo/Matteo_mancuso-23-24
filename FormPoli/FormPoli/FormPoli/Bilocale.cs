using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPoli
{
    public class Bilocale : Edificio
    {
        public Bilocale() : base(2, 100, "bilocale")
        {

        }

        public override string ToString()
        {
            return "Bilocale";
        }
    }

}
