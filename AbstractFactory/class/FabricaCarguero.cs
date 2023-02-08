using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FabricaCarguero : IFabrica
    {     
        public void ConstruirTerrestre()
        {
            new TerrestreCarguero().mostrar(); 
        }

        public void ConstruirMaritimo()
        {
            new MaritimoCarguero().mostrar();
        }

        public void mostrar()
        {
            Console.WriteLine("Creacion Cargueros exitosa");
        }
    }
}
