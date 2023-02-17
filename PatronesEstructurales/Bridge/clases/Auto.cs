using interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adapter
{
    public class Auto: IVehiculo
    {
        protected int anio;
        protected string modelo;
        protected string marca;
        
        public Auto(string marca, string modelo, int anio = 0)
        {
            this.anio = (anio == 0) ? System.DateTime.Now.Year : anio;
            this.modelo = modelo;
            this.marca = marca;
            Console.WriteLine("-> Auto Creado...."+ this.ToString());
        }
                
        public override string ToString()
        {
            return "Modelo: " + modelo + " Marca:" + marca + " Anio:" + anio;
        }
    }
}
