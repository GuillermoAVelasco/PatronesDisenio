using Composite;
using Composite.clases;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patron Creacional Composite");
            Console.WriteLine();
            Console.WriteLine("* Se emplea cuando es tipo de Estructura tipo Arbol en el cual un componente puede tener a su vez varios componentes.");
            Console.WriteLine();
            Console.WriteLine("* En el siguiente ejemplo se muestra como un vehiculo esta compuesto de varias autopartes y cada una de ellas a su vez esta compuesto de varias partes simples como un tornillo a otras compuestas.");
            Console.WriteLine();
            Console.WriteLine("* Usare el ejemplo anterior de Singleton para adaptarlo al nuevo patron");
            Console.WriteLine();

            Console.WriteLine("Creando Plan de Ensamblaje de Vehiculos..");
            Auto auto = new Auto("Renault", "Clio", 2023);

            Console.WriteLine("Agregando Componente Requerido Puertas");
            
            AutoParte puertas = new AutoParte("4Puertas");
            puertas.Agregar(new Parte("4Vidrios"));
            puertas.Agregar(new Parte("4Manijas"));
            puertas.Agregar(new Parte("2Retrovisores"));
            puertas.Agregar(new Parte("4Cerraduras"));
            auto.setComponente(puertas);

            Console.WriteLine("Agregando Sensores a las Puertas");

            AutoParte sensores = new AutoParte("Sensores");
            sensores.Agregar(new Parte("4Bloqueadores"));
            sensores.Agregar(new Parte("Sensor de Proximidad"));

            auto.setComponente(sensores);
            Console.WriteLine();
            
            Thread singleton1 = new Thread(() =>
            {
                LineaEnsamblaje.CrearInstancia("Primero");
            });
            Console.WriteLine();
            Console.WriteLine("Comienzo");

            LineaEnsamblaje.agregarVehiculo(auto);

            LineaEnsamblaje.mostrarVehiculos();

            Console.WriteLine("Mostrando Vehiculo Ingresado");
            auto.getComponentes();
            
            singleton1.Start();

            singleton1.Join();



        }
    }
}