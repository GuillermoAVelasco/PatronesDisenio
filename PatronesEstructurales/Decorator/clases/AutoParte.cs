using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Decorator
{
    public class AutoParte:PartesDecorador
    {
        public AutoParte(Componente comp, string nombre) : base(comp,nombre)
        {
            
        }
    }
}
