namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Implememtando Patron Builder -----");
            Console.WriteLine("* Consiste cuando un proceso de creacion se compone de una complejidad muy grande para construir el objeto");
            Console.WriteLine("* Este puede variar haciendo que el constructor sea gigantesco debido a los parametros requeridos");
            Console.WriteLine("* Solucion es crear una clase que construya el vehiculo simplificando en este caso la clase auto");
            Console.WriteLine("* Debido a los procesos de produccion puede verse incorporada una clase llamada Direccion que indica como fabricar o puede ser llamada desde el cliente");
            Console.WriteLine();
            Console.WriteLine("* Iniciando Proceso de Fabricacion-->");
            Console.WriteLine();
            Console.WriteLine("* Vehiculo Deportivo -->");
            DireccionFabricacion direccion= new DireccionFabricacion();
            ConstructorAuto constructor= new ConstructorAuto("Renault","Megane",2022);
            direccion.FabricaDeportivo(constructor);
            Console.WriteLine();
            Console.WriteLine("* Vehiculo Comun -->");
            DireccionFabricacion direccion2 = new DireccionFabricacion();
            ConstructorAuto constructor2 = new ConstructorAuto("Renault", "Sandero", 2022);
            direccion2.FabricaComun(constructor2);
            Console.WriteLine();
            Console.WriteLine("* Fabricacion Finalizada");
        }
    }
}