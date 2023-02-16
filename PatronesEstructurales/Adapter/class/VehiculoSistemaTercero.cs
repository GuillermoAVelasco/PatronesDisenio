using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class VehiculoSistemaTercero
    {
        protected string modelo = "";
        protected string marca = "";
        protected string tipo = "";
        //etc...

        public VehiculoSistemaTercero(string modelo, string marca, string tipo)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.tipo = tipo;
        }

        public string obtenerModelo() { return modelo; }

        public string obtenerMarca() { return marca; }

        public string obtenerTipo() { return tipo; }

        public override string ToString()
        {
            return "Modelo: "+modelo+"/"+tipo+" Marca:"+marca;
        }
    }
}
