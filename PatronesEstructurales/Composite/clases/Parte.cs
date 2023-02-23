using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.clases
{
    public class Parte: Componente
    {
        public Parte(string nombre) : base(nombre) { 
        
        }

        public bool EsCompuesto()
        {
            return false;
        }
    }
}
