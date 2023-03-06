using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class LineaEnsamblaje
    {
        private LineaEnsamblaje() { }

        private static LineaEnsamblaje _instancia;

        private static readonly object _bloqueo = new object();

        private static FlyweightFabrica _linea = new FlyweightFabrica();

        public static LineaEnsamblaje CrearInstancia(string nombre)
        {
            //verifica que no este creado
            if (_instancia == null)
            {
                //bloquea
                lock (_bloqueo)
                {
                    if (_instancia == null)
                    {
                       _instancia= new LineaEnsamblaje();
                        Console.WriteLine("Comenzando a encender Linea Ensamblaje: "+nombre);
                    }

                }
            }
            return _instancia;
        }

        public static void agregarVehiculo(AutoComponente vehiculo)
        {
            Console.WriteLine("Agregando a Linea de Ensamblaje.");
            _linea.AgregarAFabrica(vehiculo);
            Console.WriteLine();
        }

        public static void mostrarVehiculos()
        {
            Console.WriteLine("Mostrando Vehiculos en Linea de Ensamblaje.");
            _linea.getListado();
        }
    }
}
