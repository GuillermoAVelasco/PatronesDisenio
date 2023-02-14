using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IFabrica
    {
        public void ColocarPuertas();
        public void ColocarAsientos();
        public void ColocarRuedas();
        public void ColocarMotor();
        public void ColocarAccesorios();
    }
}
