using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class FlyweightFabrica
    {
        private List<Facade> _listAutos;

        public FlyweightFabrica() { 
            _listAutos = new List<Facade>();
        }

        public void AgregarAFabrica(AutoComponente auto)
        {

            Facade tipoEncontrado = _listAutos.Where(x => x.getAutoComponente().getAuto()==auto.getAuto()).FirstOrDefault();

            if (tipoEncontrado is null)
            {
                Facade facade = new Facade(auto);
                _listAutos.Add(facade);
            }
            else
            {
                ((Facade)tipoEncontrado).setCantidad();
            }
        }

        public void AgregandoComponentes(AutoComponente auto)
        {
            Facade tipoEncontrado = _listAutos.Where(x => x.getAutoComponente().getAuto() == auto.getAuto()).FirstOrDefault();

            if (tipoEncontrado !=null)
            {
                tipoEncontrado.AgregandoPuertas();
                tipoEncontrado.AgregarSensores();
            }
        }

        public void getListado()
        {
            _listAutos.ForEach(x =>
            {
                Console.WriteLine(x.getAutoComponente() + "Cantidad:" + x.getCantidad());
                ((AutoComponente)x.getAutoComponente()).getComponentes();
            });
        }
    }
}
