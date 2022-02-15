using System;
using System.Collections.Generic;
using System.Text;

namespace Modul3
{
    class Temperatur
    {
        static void Main(string[] args)
        {
            double[] temperatur = { 23.4, 10.2, 3.6, 2.9, 17.8, 25.1, 15.3, 14.9, 22.2, 23.3 };
            //c
            for (int i = 0; i <10; i++)
            {
                temperatur[i] = randomInRange(0, 40);
            }

            Console.WriteLine("Temperaturer:");
            foreach (double d in temperatur)
            {
                Console.Write(d + "  ");
            }
            //a
            Console.WriteLine();
            foreach (double d in temperatur)
            {
                if (d > 25.0)
                {
                    Console.WriteLine("temperatur større end 25 grader: "+d);
                }
            }
            //b
            int greater = GreaterCount(temperatur, 10);
            Console.WriteLine("antal temperaturer større end 10 grader: "+greater);
        }

        static int GreaterCount(double[] array, double min)
        {
            int ret = 0;
            foreach(double n in array)
            {
                if (n > min)
                {
                    ret++;
                }
            }

            return ret;
        }

        static double randomInRange(int min, int max)
        {
            Random r = new Random();
            double res = r.NextDouble() * (double)(max - min) + min;
           
            return res;
        }
    }
}
