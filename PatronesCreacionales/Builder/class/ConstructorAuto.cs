using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ConstructorAuto : IFabrica
    {
        private Auto auto;

        public ConstructorAuto(string marca,string modelo, int anio) {
            Console.WriteLine("* Proceso de Construccion de Auto.");
            auto = new Auto(marca,modelo,anio);
        }

        public void ColocarAccesorios()
        {
            Console.WriteLine("> Accesorios OK.");
        }

        public void ColocarAccesoriosDeportivos()
        {
            Console.WriteLine("> Accesorios Deportivos OK.");
        }

        public void ColocarAsientos()
        {
            Console.WriteLine("> Asientos OK.");
        }

        public void ColocarMotor()
        {
            Console.WriteLine("> Motor OK.");
        }

        public void ColocarPuertas()
        {
            Console.WriteLine("> Puertas OK.");
        }

        public void ColocarRuedas()
        {
            Console.WriteLine("> Ruedas OK.");
        }
    }
}
