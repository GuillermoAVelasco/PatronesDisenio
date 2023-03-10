using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade
    {
        private Auto _auto { get; set; }
        public Facade(Auto auto)
        {
            _auto = auto;
        }

        private void AgregandoComponente(string nombre, Parte[] partes)
        {
            Parte componente = new Parte(nombre);
            if (partes.Count() > 0)
            {
                AutoParte autoParte = new AutoParte(partes[0],nombre);
                for(int i = 1; i < partes.Count(); i++)
                {
                    autoParte.Agregar(partes[i]);
                }
                
                _auto.setComponente(autoParte);
            }            
            
        }

        public void AgregandoPuertas()
        {
            string parte = "Puertas";
            AgregandoComponente(parte,new Parte[]{ new Parte("4Puertas"),new Parte("4Vidrios"), new Parte("4Manijas"), new Parte("2Retrovisores"), new Parte("4Cerraduras")});
        }

        public void AgregarSensores()
        {
            string parte = "Sensores";
            AgregandoComponente(parte, new Parte[] { new Parte("4Sensores"), new Parte("44Bloqueadores"), new Parte("Sensor de Proximidad") });
        }
    }
}
