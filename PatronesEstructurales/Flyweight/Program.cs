namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patron Creacional Flyweight");
            Console.WriteLine();
            Console.WriteLine("* Se emplea cuando se requiere ahorrar memoria debido a una gran cantidad de objetos repetidos, se refactoriza entre elementos intrinsecos (constanstes) y extrinsecos (particulares).");
            Console.WriteLine();
            Console.WriteLine("* Usare el ejemplo anterior para simplificar el proceso de agregar partes a un vehiculo.");
            Console.WriteLine();
            Console.WriteLine("* Se complica bastante al momento de implementar este patron por algo aconsejan no usarlo a menos que se este teniendo problemas en memoria.");
            Console.WriteLine();
            Console.WriteLine("* Incluso implementar el ejemplo anterior hace que el mismo sea mas dificil de acomodar, tal vez haya una mejor forma de realizarlo pero bueno es lo que rapidamente pude abstraer para implementar dicho patron.");
            Console.WriteLine();

            Console.WriteLine("Creando Plan de Ensamblaje de Vehiculos..");
            Console.WriteLine("1 Vehiculo");
            AutoComponente auto = new AutoComponente("2222","UZU000", new Auto("Renault", "Clio", 2023));

            Console.WriteLine("Agregando Componente Requerido Puertas y Sensores");
            FlyweightFabrica fabrica = new FlyweightFabrica();
            fabrica.AgregarAFabrica(auto);
            fabrica.AgregandoComponentes(auto);
            Console.WriteLine();

            Console.WriteLine("2 Vehiculo");
            AutoComponente auto3 = new AutoComponente("0000", "oZU000", new Auto("Renault", "Clio", 2023));

            Console.WriteLine("Agregando Componente Requerido Puertas y Sensores");
            fabrica.AgregarAFabrica(auto3);
            fabrica.AgregandoComponentes(auto3);
            Console.WriteLine();


            Console.WriteLine("3 vehiculo..");
            AutoComponente auto2 = new AutoComponente("33333","UZU123",new Auto("Renault", "Sandero", 2023));
            Console.WriteLine("Agregando Componente Requerido Puertas y Sensores");
            fabrica.AgregarAFabrica(auto2);
            fabrica.AgregandoComponentes(auto2);
            Console.WriteLine();


            Thread singleton1 = new Thread(() =>
            {
                LineaEnsamblaje.CrearInstancia("Primero");
            });


                        Console.WriteLine();
            Console.WriteLine("Comienzo");

            LineaEnsamblaje.agregarVehiculo(auto);

            LineaEnsamblaje.agregarVehiculo(auto3);

            LineaEnsamblaje.agregarVehiculo(auto2);

            singleton1.Start();

            singleton1.Join();

            LineaEnsamblaje.mostrarVehiculos();

            Console.WriteLine("Mostrando Vehiculo Ingresado");
            fabrica.getListado();


        }
    }
}