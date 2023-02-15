namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patron Creacional Singleton");
            Console.WriteLine("* Una unica instancia en todo el programa.");
            Console.WriteLine("* Esto sirve para que varias instancias accedan a ella para obtener configuraciones, acceso a db etc.");

            Console.WriteLine("Creacion de Instancias singleton/ deberia crearse una pero compartir la misma ambas");

            //Task.Run(() => LineaEnsamblaje.CrearInstancia("0", new Auto("Renault", "Clo", 2014))).Wait();

            Thread singleton1 = new Thread(() =>
            {
                LineaEnsamblaje.CrearInstancia("Primero",new Auto("Renault", "Kangoo", 2014));                
            });

            Thread singleton2 = new Thread(() =>
            {
                LineaEnsamblaje.CrearInstancia("Segundo", new Auto("Renault", "Logan", 2010));
            });

            Console.WriteLine("Comienzo");
            //Agrega a linea ensamblaje Kangoo
            singleton1.Start();
            //No se puede Agregar a linea ensamblaje Logan
            singleton2.Start();

            singleton1.Join();
            singleton2.Join();
        }
    }
}