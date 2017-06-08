using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace Wzorce_projektowe.TLP
{
    class TLPMain
    {
        public void mainTLP()
        {
            var sum = 0;
            Thread[] thList = new Thread[4];
            Thread[] threads = new Thread[4];

            //asynchronicznie
            Console.WriteLine("Asynchronizacja");
            for (int i = 0; i < thList.Length; i++)
            {
                threads[i] = new Thread(new ThreadStart(add));
                threads[i].Name = "Wątek " + i;

            }
            foreach (Thread t in threads)
            {
                t.Start();
            }
            foreach (Thread t in threads)
            {
                t.Join();
            }
            //zatrzymanie watka

            Console.WriteLine("Synchronizacja");
            for (int i = 0; i < threads.Length; i++)
            {

                    threads[i] = new Thread(new ThreadStart(add));
                    threads[i].Name = "Wątek " + i;                                     

            }
            foreach (Thread t in threads)
            {
                lock (threads)
                {
                    t.Start();
                }
            }
            foreach (Thread t in threads)
            {
                lock (threads)
                {
                    t.Join();
                }
            }
         }
        private static void add()
        {
            var th = Thread.CurrentThread;
            int sum = 0;
            for (int i = 0; i < 1000000; i++)
            {
                sum += 1;
            }
            Console.WriteLine("Nzawa wątka: " + th.Name + " suma = " + sum);
        }
    }
}
