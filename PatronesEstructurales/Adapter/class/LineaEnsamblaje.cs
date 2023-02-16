using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class LineaEnsamblaje
    {
        private LineaEnsamblaje() { }

        private static LineaEnsamblaje _instancia;

        private static readonly object _bloqueo = new object();

        public static LineaEnsamblaje CrearInstancia(string nombre,Auto auto)
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
                        Console.WriteLine("Auto Ingresado Linea Ensamblaje: "+nombre+" "+auto.ToString());
                    }

                }
            }
            return _instancia;
        }
    }
}
