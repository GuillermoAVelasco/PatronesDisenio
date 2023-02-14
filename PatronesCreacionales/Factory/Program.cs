namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prueba de Patron de Diseño: Factory Method");
            Console.WriteLine("* Subdivide un problema en clases, no tiene acoplamiento de codigo.");
            Console.WriteLine("* La interfaz define los tipos de vehiculos a crear pero solo a traves de la fabrica se permitira crear uno u otro vehiculo.");

            Fabrica fabrica;
            fabrica = new FabricaMaritimo();
            fabrica.mostrar();

            Console.WriteLine("---------------");

            fabrica = new FabricaTerrestre();
            fabrica.mostrar();

        }
    }
}