using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class FabricaMaritimo : Fabrica
    {
        public override Maritimo Construir()
        {
            return new Maritimo();
        }
    }
}
