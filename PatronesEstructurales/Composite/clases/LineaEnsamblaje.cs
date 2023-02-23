using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class LineaEnsamblaje
    {
        private LineaEnsamblaje() { }

        private static LineaEnsamblaje _instancia;

        private static readonly object _bloqueo = new object();

        private static List<Auto> _linea = new List<Auto>();

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

        public static void agregarVehiculo(Auto vehiculo)
        {
            Console.WriteLine("Agregando a Linea de Ensamblaje.");
            _linea.Add(vehiculo);
            Console.WriteLine();
        }

        public static void mostrarVehiculos()
        {
            Console.WriteLine("Mostrando Vehiculos en Linea de Ensamblaje.");
            _linea.ForEach(vehiculo =>
            {
                Console.WriteLine(">>>>>>"+vehiculo.ToString());
                Console.WriteLine();
            });
        }
    }
}
