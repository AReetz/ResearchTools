using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResearchTools;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            //BluetoothLEAdvertisementWatcher watcher = new BluetoothLEAdvertisementWatcher();
            Random randNum = new Random();
            Single[] values = Enumerable.Repeat(0, 10000).Select(i => (Single)randNum.Next(Int32.MinValue / 2, Int32.MaxValue / 2)).ToArray();

            Console.WriteLine(String.Format("{0:#.000000}\t{1:#.000000}", values.StandardDeviationNaive(), values.StandardDeviationWelford()));

            DateTime s;
            Single min = Single.NaN, max = Single.NaN;

            s = DateTime.Now;
            for (int i = 0; i < 10000; i++) min = Maths<Single>.MinVal(values);
            for (int i = 0; i < 10000; i++) max = Maths<Single>.MaxVal(values);
            Console.WriteLine((DateTime.Now - s).TotalMilliseconds);
            Console.WriteLine("min " + min + " | max: " + max);

            s = DateTime.Now;
            Parallel.For(0, 10000, m => min = Maths<Single>.MinVal(values));
            Parallel.For(0, 10000, m => max = Maths<Single>.MaxVal(values));
            Console.WriteLine((DateTime.Now - s).TotalMilliseconds);
            Console.WriteLine("min " + min + " | max: " + max);

            s = DateTime.Now;
            for (int i = 0; i < 10000; i++) min = Maths.MinVal(values);
            for (int i = 0; i < 10000; i++) max = Maths.MaxVal(values);
            Console.WriteLine((DateTime.Now - s).TotalMilliseconds);
            Console.WriteLine("min " + min + " | max: " + max);

            s = DateTime.Now;
            Parallel.For(0, 10000, m => min = Maths.MinVal(values));
            Parallel.For(0, 10000, m => max = Maths.MaxVal(values));
            Console.WriteLine((DateTime.Now - s).TotalMilliseconds);
            Console.WriteLine("min " + min + " | max: " + max);

            s = DateTime.Now;
            for (int i = 0; i < 10000; i++) min = values.StandardDeviationNaive();
            Console.WriteLine((DateTime.Now - s).TotalMilliseconds);

            s = DateTime.Now;
            for (int i = 0; i < 10000; i++) min = values.StandardDeviationWelford();
            Console.WriteLine((DateTime.Now - s).TotalMilliseconds);
        }
    }
}
