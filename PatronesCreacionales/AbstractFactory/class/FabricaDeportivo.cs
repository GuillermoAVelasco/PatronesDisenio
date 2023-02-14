using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FabricaDeportivo : IFabrica
    {
        public void ConstruirTerrestre()
        {
            new TerrestreDeportivo().mostrar();
        }

        public void ConstruirMaritimo()
        {
            new MaritimoDeportivo().mostrar();
        }

        public void mostrar()
        {
            Console.WriteLine("Creacion Deportiva exitosa");
        }
    }
}
