using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Vehiculo
    {
        protected int anio;
        protected string modelo="";
        protected string marca="";
        protected List<string> accesorios= new List<string>();
        
        public override string ToString()
        {
            return "Modelo: " + modelo + " Marca:" + marca + " Anio:" + anio+" Accesorios:"+string.Join(", ",accesorios);
        }

        public void agregarAccesorio(string acc)
        {
            accesorios.Add(acc);
        }
    }
}
