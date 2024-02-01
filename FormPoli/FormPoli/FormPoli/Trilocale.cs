using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPoli
{
    public class Trilocale : Edificio
    {
        public Trilocale() : base(3, 150, "trilocale")
        {

        }

        public override string ToString()
        {
            return "Trilocale";
        }
    }

}
