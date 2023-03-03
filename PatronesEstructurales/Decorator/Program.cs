
namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patron Creacional Decorator");
            Console.WriteLine();
            Console.WriteLine("* Se emplea cuando es tipo de Estructura requiere crear subclases pero las subclases harian explotar lo que hay hecho.");
            Console.WriteLine();
            Console.WriteLine("* Entonces se envuelve en una clase decoradora que extiende o junta lo que se requiere, y por ejemplo la clase autoparte podria tener una hermana que se llame de otra manera y haga uso de los datos de otra manera sin tener que modificar todo ya que usaria el decorador.");
            Console.WriteLine();
            Console.WriteLine("* En el siguiente ejemplo se muestra como un vehiculo esta compuesto de varias autopartes y cada una de ellas a su vez esta compuesto de varias partes simples como un tornillo a otras compuestas");
            Console.WriteLine();
            Console.WriteLine("* Usare el ejemplo anterior de Singleton para adaptarlo al nuevo patron");
            Console.WriteLine();

            Console.WriteLine("Creando Plan de Ensamblaje de Vehiculos..");
            Auto auto = new Auto("Renault", "Clio", 2023);

            Console.WriteLine("Agregando Componente Requerido Puertas");
            
            Parte componente = new Parte("4Puertas");
            AutoParte puertas = new AutoParte(componente,"Puertas");
            puertas.Agregar(new Parte("4Vidrios"));
            puertas.Agregar(new Parte("4Manijas"));
            puertas.Agregar(new Parte("2Retrovisores"));
            puertas.Agregar(new Parte("4Cerraduras"));
            auto.setComponente(puertas);

            Console.WriteLine("Agregando Sensores a las Puertas");

            Parte componente2 = new Parte("4Sensores");
            AutoParte sensores = new AutoParte(componente2,"Sensores");
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