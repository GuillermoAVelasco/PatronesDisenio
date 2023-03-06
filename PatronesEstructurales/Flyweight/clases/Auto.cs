using Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Flyweight
{
    public class Auto
    {
        protected int Anio { get; set; }
        protected string Modelo { get; set; }
        protected string Marca { get; set; }
        private List<Componente> _listaComponentes= new List<Componente>();
                
        public Auto(string marca, string modelo, int anio = 0)
        {
            Anio = (anio == 0) ? System.DateTime.Now.Year : anio;
            Modelo = modelo;
            Marca = marca;
            Console.WriteLine("-> Auto Creado...."+ this.ToString());
        }
                
        public override string ToString()
        {
            return "Modelo: " + Modelo + " Marca:" + Marca + " Anio:" + Anio;
        }

        public string getClave()
        {
            return Modelo+Marca+Anio;
        }

        public void getComponentes()
        {
            Console.WriteLine();
            Console.WriteLine(this.ToString());
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
