namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implementando Interfaz clone
            Console.WriteLine("Patron de Diseño: Prototype.");
            Console.WriteLine();
            Auto auto = new Auto("Ford","Mustang");
            auto.agregarAccesorio("Llantas Deportivas");
            auto.agregarAccesorio("Aleron");
            Console.WriteLine("> Creacion de copia superficial Auto1");
            Auto auto2= auto.ClonSuperficial();

            Console.WriteLine("> Auto2: Modificando valores");
            auto2.cambiarModelo("Citroen");
            auto2.cambiarMarca("Berlingo");
            auto2.agregarAccesorio("Luces neon");
            auto2.cambiarAnio(2022);

            Console.WriteLine("> Auto 2");
            Console.WriteLine(auto2);

            Console.WriteLine("> Auto 1");
            Console.WriteLine(auto);

            Console.WriteLine("Creacion Auto 3 copia profunda de Auto1.");
            Auto auto3 = auto.ClonProfunda();
            auto3.agregarAccesorio("Turbo");

            Console.WriteLine("> Auto3");
            Console.WriteLine(auto3);


            Console.WriteLine("> Auto1");
            Console.WriteLine(auto);
        }
    }
}