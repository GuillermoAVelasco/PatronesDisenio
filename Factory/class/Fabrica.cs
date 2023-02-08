using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Fabrica
    {
        public abstract ITransporte Construir();
        public void mostrar()
        {
            ITransporte transporte = Construir();
            transporte.mostrar();
        }
    }
}
