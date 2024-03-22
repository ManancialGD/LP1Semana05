using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    
    /* <summary>

        STOPWATCH:
        namespace: System.Diagnostics
        Da propriedade que indica tempo decorrido em milissegundos: ElapsedMilliseconds
        Da propriedade que indica se cronómetro está a contar o tempo: IsRunning
        Do método para começar a contar o tempo: Start()
        Do método para parar de contar o tempo: Stop()

     </summary> */

    class Program
    {
            static Stopwatch crono1;
            static Stopwatch crono2;
        static void Main(string[] args)
        {
            crono1 = new Stopwatch();
            crono2 = new Stopwatch();
            
            crono1.Start();
            Console.WriteLine("Crono1 started!");

            Console.WriteLine("Program paused!");
            Thread.Sleep(600);
            Console.WriteLine("Program unpaused!");

            crono2.Start();
            Console.WriteLine("Crono2 started!");

            Console.WriteLine("Program paused!");
            Thread.Sleep(200);
            Console.WriteLine("Program unpaused!");

            crono1.Stop();
            Console.WriteLine("Crono1 stopped at {0}", Math.Round((float)crono1.ElapsedMilliseconds/1000, 3));

            crono2.Stop();
            Console.WriteLine("Crono2 stopped at {0}", Math.Round((float)crono2.ElapsedMilliseconds/1000, 3));
        }
    }
}
