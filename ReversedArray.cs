using System;

namespace Modul3
{
    class ReversedArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvor mange elementer vil du have gemt i dit array?");
            int antal = Int32.Parse(Console.ReadLine());
            int[] numbers = new int[antal];
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine("Hvilket tal skal vi gemme nu?");
                int x = Int32.Parse(Console.ReadLine());
                numbers[i] = x;
            }
            Console.WriteLine("Dit array indeholder følgende værdier i omvendt rækkefølge: ");
            for (int j = antal; j > 0; j--)
            {
                Console.WriteLine(numbers[j - 1]);
            }
        }
    }
}
