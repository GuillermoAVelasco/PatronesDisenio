using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class DireccionFabricacion
    {
        public void FabricaComun(ConstructorAuto constructor)
        {
            constructor.ColocarMotor();
            constructor.ColocarPuertas();
            constructor.ColocarRuedas();
            constructor.ColocarAsientos();
            constructor.ColocarAccesorios();          
        }

        public void FabricaDeportivo(ConstructorAuto constructor)
        {
            constructor.ColocarMotor();
            constructor.ColocarPuertas();
            constructor.ColocarRuedas();
            constructor.ColocarAsientos();
            constructor.ColocarAccesorios();
            constructor.ColocarAccesoriosDeportivos();
        }
    }
}
