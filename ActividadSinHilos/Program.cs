namespace AppSinHilos;

class Program
{
    public static void DoTrabajoPesado()
    {
        Console.WriteLine("DoTrabajoPesado: estoy levaantando un camion!!");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: Candado! Necesito una sieasta de 3 seg.");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: 1....");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: 2....");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: 3....");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: Ya desperte!");
    }
    public static void DoAlgo()
    {
        Console.WriteLine("DoAlgo: Estoy haciendo algo aqui!");
        for (int i = 0; i < 20; i++)
            Console.Write($"{i} ");
        Console.WriteLine();
        Console.WriteLine("DoAlgo: Ya termine!");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("César González López: ");

        Console.WriteLine("El Main thread comienza aqui.");

        Program.DoTrabajoPesado();

        Program.DoAlgo();

        Console.WriteLine("El Main thread termina aqui.");
        Console.WriteLine("Presione cualquier tecla para terminar...");
        Console.ReadKey(true);
    }
}
