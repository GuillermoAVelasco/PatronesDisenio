namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patron Creacional Facade");
            Console.WriteLine();
            Console.WriteLine("* Se emplea para emplear una una interfaz simplificada a una serie de operaciones de una biblioteca framework o grupo de clases.");
            Console.WriteLine();
            Console.WriteLine("* Usare el ejemplo anterior para simplificar el proceso de agregar partes a un vehiculo.");
            Console.WriteLine();
            Console.WriteLine("* Usare el ejemplo anterior de Singleton para adaptarlo al nuevo patron");
            Console.WriteLine();

            Console.WriteLine("Creando Plan de Ensamblaje de Vehiculos..");
            Auto auto = new Auto("Renault", "Clio", 2023);

            Console.WriteLine("Agregando Componente Requerido Puertas");

            Facade facade = new Facade(auto);
            facade.AgregandoPuertas();

            Console.WriteLine("Agregando Sensores a las Puertas");
            facade.AgregarSensores();
            Console.WriteLine();


            Console.WriteLine("2 vehiculo..");
            Auto auto2 = new Auto("Renault", "Sandero", 2023);

            Console.WriteLine("Agregando Componente Requerido Puertas");

            facade = new Facade(auto2);
            facade.AgregandoPuertas();

            Console.WriteLine("Agregando Sensores a las Puertas");
            facade.AgregarSensores();
            Console.WriteLine();


            Thread singleton1 = new Thread(() =>
            {
                LineaEnsamblaje.CrearInstancia("Primero");
            });
            Console.WriteLine();
            Console.WriteLine("Comienzo");

            LineaEnsamblaje.agregarVehiculo(auto);

            LineaEnsamblaje.agregarVehiculo(auto2);

            LineaEnsamblaje.mostrarVehiculos();

            Console.WriteLine("Mostrando Vehiculo Ingresado");
            auto.getComponentes();
            auto2.getComponentes();

            singleton1.Start();

            singleton1.Join();
        }
    }
}