using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MaritimoDeportivo : Maritimo
    {
        public override void mostrar()
        {
            Console.WriteLine("Maritimo -> Deportivo"); ;
        }        
    }
}
