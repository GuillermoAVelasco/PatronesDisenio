using AbstractFactory;

namespace AbstractAbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prueba de Patron de Diseño: Abstract Factory");
            Console.WriteLine("* Subdivide un problema en clases e interfaces, no tiene acoplamiento de codigo.");
            Console.WriteLine("* La interfaz define los tipos de vehiculos a crear pero solo a traves de la fabrica determinada Carguera/Deportiva se permitira crear una serie de vehiculos deportivos o cargueros.");
            Console.WriteLine("* Este patron permite extender clases definiendo un tipo por ejemplo si son deportivos puede ser que hoy se necesite un terrestre y maritimo pero mañana se necesite tambien aereo por ello se permitira extender facilmente.");
            Console.WriteLine("* El uso de interfaces permite extender desde fabricas a vehiculos.");



            Console.WriteLine("Construccion de Fabrica Carguero");
            //pedido de cliente1 se pudiera haber encapsulado en alguna clase pedido

            IFabrica fabrica = new FabricaCarguero();
            fabrica.ConstruirMaritimo();
            fabrica.ConstruirTerrestre();
            fabrica.mostrar();

            Console.WriteLine("Construccion de Fabrica Deportiva");
            //pedido de cliente2 se pudiera haber encapsulado en alguna clase pedido

            fabrica = new FabricaDeportivo();
            fabrica.ConstruirMaritimo();
            fabrica.ConstruirTerrestre();
            fabrica.mostrar();


        }
    }
}