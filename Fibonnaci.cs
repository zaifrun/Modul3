using System;
using System.Collections.Generic;
using System.Text;

namespace Modul3
{
    class Fibonnaci
    {

        static void Main(string[] args)
        {
            Console.WriteLine("input max tal, hvortil fibonnaci skal beregnes");
            long max = int.Parse(Console.ReadLine());
            long currentMax = 0;
            long currentFibNumber = 0;
            while (currentMax<=max)
            {
                currentMax = FibonnaciSimple(currentFibNumber);
                currentFibNumber++;
                if (currentMax <=max )
                    Console.WriteLine($"Fibonacci tal nr {currentFibNumber} er {currentMax}");

            }
            List<long> fibList = new List<long>();
            FibonnaciList(1000, fibList);
            Console.WriteLine("elements in list");
            for (int i = 0; i < fibList.Count; i++)
            {
                Console.WriteLine($"Fibonacci tal nr {i+1} er {fibList[i]}");

            }


        }



        static void FibonnaciList(long max,List<long> list)
        {
            if (list.Count==0)
            {
                list.Add(0);
                list.Add(1);
                //evt. console writeln her hvis man vil
                FibonnaciList(max, list);
            }
            else 
            {
                int size = list.Count;
                long nytTal =list[size-1]+list[size-2]; //de to sidste tal
                if (nytTal <= max)
                {
                    list.Add(nytTal);
                    //evt. console writeln her hvis man vil
                    FibonnaciList(max, list);
                }

            }     

        }

        static long FibonnaciSimple(long n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return FibonnaciSimple(n - 2) + FibonnaciSimple(n - 1);
        }
    }
}
