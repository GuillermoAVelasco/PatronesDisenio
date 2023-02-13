using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prototype
{
    public class Auto : Vehiculo
    {
        public Auto(string marca, string modelo, int anio = 0)
        {
            this.anio = (anio == 0) ? System.DateTime.Now.Year : anio;
            this.modelo = modelo;
            this.marca = marca;
            Console.WriteLine("-> Vehiculo Creado....");
        }

        public Auto ClonSuperficial() //copia todo pero la referencia al objeto apunta al original
        {
            return (Auto) this.MemberwiseClone();            
        }

        public Auto ClonProfunda() //copia profunda
        {
            var autox= (Auto)this.MemberwiseClone();
            autox.accesorios = new List<string>();
            accesorios.ForEach(acc => autox.accesorios.Add(acc));

            return autox;
        }

        public void cambiarModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public void cambiarMarca(string marca)
        {
            this.marca = marca;
        }

        public void cambiarAnio(int anio)
        {
            this.anio = anio;
        }
    }
}
