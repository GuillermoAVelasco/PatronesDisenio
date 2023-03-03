using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Decorator
{
    public abstract class Componente
    {
        private string _nombre;

        public Componente(string nombre) { _nombre = nombre; }

        public string getNombre() { return _nombre; }
        public void setNombre(string nombre) { _nombre=nombre; }

        public bool EsCompuesto()
        {
            return true;
        }

        public override string ToString()
        {
            return getNombre();
        }

    }
}
