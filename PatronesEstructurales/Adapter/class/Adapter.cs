using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Adapter : IAdapterVehiculo
    {
        private readonly VehiculoSistemaTercero _vehiculo;

        public Adapter(VehiculoSistemaTercero v)
        {
            _vehiculo= v;
        }

        public string MostrarVehiculo()
        {
            return _vehiculo.ToString();
        }

        public Auto ObtenerVehiculo()
        {            
            return new Auto(_vehiculo.obtenerMarca(),_vehiculo.obtenerModelo() + "/" + _vehiculo.obtenerTipo());            
        }
    }
}
