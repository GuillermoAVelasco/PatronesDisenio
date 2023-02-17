using interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adapter
{
    public class Camioneta: IVehiculo
    {
        protected int anio;
        protected string modelo;
        protected string marca;
        protected bool dobleTraccion;
        
        public Camioneta(string marca, string modelo, int anio = 0,bool dobleTraccion=false)
        {
            this.anio = (anio == 0) ? System.DateTime.Now.Year : anio;
            this.modelo = modelo;
            this.marca = marca;
            this.dobleTraccion= dobleTraccion;
            Console.WriteLine("-> Camioneta Creada...."+ this.ToString());
        }
                
        public override string ToString()
        {
            return "Modelo: " + modelo + " Marca:" + marca + " Anio:" + anio +" Doble Traccion:"+((!dobleTraccion)?"":"X");
        }
    }
}
