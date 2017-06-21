using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wzorce_projektowe.TLP
{
    class TLPMain2
    {
        public void tlpMain2()
        {
            List<int[]> input = new List<int[]>();
            Random rand = new Random();
            Stopwatch sw = new Stopwatch();
            int size = 10000;
            int prSum = 0;
            int prfSum = 0;
            int sqSum = 0;
            TimeSpan t1, t2, t3;

            //Init tab
            for (int j = 0; j < size; j++)
            {
                int[] line = new int[size];
                for (int i = 0; i < size; i++)
                {
                    line[i] = rand.Next(100);
                }
                input.Add(line);
            }

            //Sekwencyjnie
            sw.Start();
            foreach (var line in input)
            {
                foreach (var i in line)
                    sqSum += i;
            }
            t1 = sw.Elapsed;

            //Równolegle
            sw.Restart();
            var task = new List<Task<int>>();
            foreach (var line in input)
            {
                task.Add(Task.Run(() => sum(line)));
            }

            Task.WaitAll(task.ToArray());

            foreach (var t in task)
            {
                prSum += t.Result;
            }
            t2 = sw.Elapsed;

            //ParrarelFor
            sw.Restart();
            Parallel.ForEach(input,
                                () => 0,
                                (array, loop, partresult) => { foreach (int i in array) { partresult += i; }; return partresult; },
                                (result) => Interlocked.Add(ref prfSum, result)
                                );
            t3 = sw.Elapsed;
            sw.Stop();

            Console.WriteLine("Metoda:\t{0,12} Wynik: {1} Czas: {2,4} ms", "Sekwencyjna", sqSum, t1.Milliseconds);
            Console.WriteLine("Metoda:\t{0,12} Wynik: {1} Czas: {2,4} ms", "Równoległa", prSum, t2.Milliseconds);
            Console.WriteLine("Metoda:\t{0,12} Wynik: {1} Czas: {2,4} ms", "ParrarelFor", prfSum, t3.Milliseconds);
            Console.ReadLine();
        }

        static int sum(int[] line)
        {
            var sum = 0;
            foreach (var i in line)
                sum += i;

            return sum;
        }
    }
}
