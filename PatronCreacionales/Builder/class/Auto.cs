using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Auto
    {
        private int _anio;
        private string _modelo;
        private string _marca;

        public Auto(string marca,string modelo,int anio=0)
        {
            _anio= (anio==0)?System.DateTime.Now.Year:anio;
            _modelo= modelo;
            _marca= marca;
            Console.WriteLine("Primera Fase Vehiculo Creado....");
        }
    }
}
