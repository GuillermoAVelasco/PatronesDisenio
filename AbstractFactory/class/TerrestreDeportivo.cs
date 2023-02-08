using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class TerrestreDeportivo : TransporteTerrestre
    {
        public override void mostrar()
        {
            Console.WriteLine("Terrestre -> Deportivo"); ;
        }        
    }
}
