namespace AppConHilosATM;

class Program
{
    static int accountBalance = 1000;
    static Random random= new Random();

    static void PerformTransaction (object? threadId)
    {
        for (int i = 0; i < 5; i++)
        {
            int amountTowithdraw = random.Next(10,101);

            Thread.Sleep(1000);

            lock (typeof(Program))
            {
                if(accountBalance >= amountTowithdraw)
                {
                    accountBalance -= amountTowithdraw;
                    Console.WriteLine($"Thread {threadId}: Se retiraron " +
                        "${amountTowithdraw} pesos. Quedan ${accountBalance} pesos");
                }
                else
                    Console.WriteLine($"Thread {threadId}: Fondos " +
                        "insuficientes. Se requieren: ${amountTowithdraw} pesos.");    
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Bienvenido al cajero automatico");
        Console.WriteLine($"Cuentas con ${accountBalance} pesos");
        Console.WriteLine("Presiona ener para iniciar laas transacciones...");
        Console.ReadLine();

        Thread[] threads = new Thread[5];
        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(PerformTransaction);
            threads[i].Start(i+1);
        }

        foreach(Thread thread in threads)
            thread.Join();
        Console.WriteLine("Todas las transacciones completadas.");
        Console.WriteLine($"Saldo final de la cuenta: ${accountBalance} pesos");
        
    }
}
