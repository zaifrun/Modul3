using System;
using System.Collections.Generic;
using System.Text;

namespace Modul3
{
    class SandwichMenu
    {
        static void Main(string[] args)
        {
            string[] breadtype = { "rugbrød", "lyst brød", "valnøddebrød", "grov toast", "glutenfrit brød", "pølsebrød" };
            string[] main = { "oksekød", "kalkun", "kylling", "falafel", "kikærter", "laks", "rejer", "pølse" };
            string[] topping = { "honning", "mayo", "sennep", "ketchup", "hvidløgsdressing", "fransk hot dog dressing", "chili" };

            Random rand = new Random();
            int index1 = rand.Next(breadtype.Length);
            int index2 = rand.Next(main.Length);
            int index3 = rand.Next(topping.Length);

            Console.WriteLine("Du får et " + breadtype[index1] + " med " + main[index2] + " toppet med " + topping[index3] + ". God fornøjelse!");


        }
    }
}
