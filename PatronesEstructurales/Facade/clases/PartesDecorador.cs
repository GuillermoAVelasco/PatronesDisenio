using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Facade
{
    public abstract class PartesDecorador : Componente
    {
        protected List<Componente> _listaComponentes = new List<Componente>();

        public PartesDecorador(Componente comp,string nombre) : base(nombre)
        {
            Agregar(comp);
        }

        public void Agregar(Componente componente)
        {
            _listaComponentes.Add(componente);
        }

        public void Remover()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string partes="> "+this.getNombre()+" Compuesto de:";

            _listaComponentes.ForEach(componente =>
            {
                partes += componente.ToString()+", ";
            });

            return partes;
        }
    }
}
