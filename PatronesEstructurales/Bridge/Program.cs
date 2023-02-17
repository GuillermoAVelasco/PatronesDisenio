using Adapter;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patron Creacional Bridge");
            Console.WriteLine();
            Console.WriteLine("* Se emplea cuando hay mucha variedad de tipos por lo que expandir en subclases y herencia hace que se creen demasiadas clases.");
            Console.WriteLine();
            Console.WriteLine("* Por ejemplo un sistema puede ser de linea de ensamblaje de autos, en este caso se abstrae en una interface vehiculo y de alli se desprenden los tipos permitiendo que la linea ensamblaje trabaje con ellos.");
            Console.WriteLine();
            Console.WriteLine("* Usare el ejemplo anterior de Singleton para adaptarlo al nuevo patron");
            Console.WriteLine();

            Console.WriteLine("Creando Plan de Ensamblaje de Vehiculos..");
            Auto auto = new Auto("Renault", "Clio",2023);
            Console.WriteLine();
            Camioneta camioneta = new Camioneta("Renault", "Kangoo",2023);

            Thread singleton1 = new Thread(() =>
            {
                LineaEnsamblaje.CrearInstancia("Primero");
            });
            Console.WriteLine();
            Console.WriteLine("Comienzo");

            LineaEnsamblaje.agregarVehiculo(auto);
            LineaEnsamblaje.agregarVehiculo(camioneta);

            LineaEnsamblaje.mostrarVehiculos();
            singleton1.Start();
            

            singleton1.Join();
            
        }
    }
}