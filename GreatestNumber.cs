using System;
using System.Collections.Generic;
using System.Text;

namespace Modul3
{
    class GreatestNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 7, 1, 9, 3, 6, 2 };
            int highest = Int32.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > highest)
                {
                    highest = numbers[i];
                }
            }
            if (highest != Int32.MinValue)
            {
                Console.WriteLine("Den højeste værdi er " + highest);
            }
            else
            {
                Console.WriteLine("Der blev ikke fundet en højeste værdi");
            }
        }
    }
}
