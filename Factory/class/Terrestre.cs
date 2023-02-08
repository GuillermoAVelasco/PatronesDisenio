using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Terrestre : ITransporte
    {
        public void mostrar()
        {
            Console.WriteLine("Terrestre");
        }
    }
}
