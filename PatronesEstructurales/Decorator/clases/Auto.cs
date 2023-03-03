using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Decorator
{
    public class Auto
    {
        protected int anio;
        protected string modelo;
        protected string marca;
        private List<Componente> _listaComponentes= new List<Componente>();
        
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

        public void getComponentes()
        {
            Console.WriteLine("> Listando Componentes: ");
            _listaComponentes.ForEach(componente =>
            {
                Console.WriteLine(">> " + componente.ToString());
            });
        }

        public void setComponente(Componente c)
        {
            Console.WriteLine("<Agregando Componente>");
            _listaComponentes.Add(c);
        }
    }
}
