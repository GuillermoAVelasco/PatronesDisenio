namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patron Creacional Adapter");
            Console.WriteLine();
            Console.WriteLine("* Se emplea cuando se usa un servicio de terceros o propio pero que posee un resultado distinto a lo que recibe el sistema por lo que debe acomodarse.");
            Console.WriteLine();
            Console.WriteLine("* Por ejemplo un sistema puede ser de linea de ensamblaje de autos, la empresa no quiere modificar el sistema pero en algun momento comienza a ingresar camiones u otros vehiculos.");
            Console.WriteLine();
            Console.WriteLine("* Una opcion puede ser emplear abstract factory crear una instancia vehiculo y de ahi desprender pero si en este caso la empresa no quisiera modificarlo y solo quiere anexar los datos de los otros tipos de vehiculos desde un sistema de tercero.");
            Console.WriteLine();
            Console.WriteLine("* Usare el ejemplo anterior de Singleton para adaptarlo al nuevo patron");
            Console.WriteLine();
            //creo una instancia de Camion
            Console.WriteLine("Mandaremos un camion el sistema solo esta preparado para recibir autos");
            Console.WriteLine();
            VehiculoSistemaTercero vehiculo = new VehiculoSistemaTercero("T30 truck", "Shineray","Camion");

            Thread singleton1 = new Thread(() =>
            {
                LineaEnsamblaje.CrearInstancia("Primero", new Adapter(vehiculo).ObtenerVehiculo());
            });
            Console.WriteLine();
            Console.WriteLine("Comienzo");
            singleton1.Start();
            
            singleton1.Join();
            
        }
    }
}