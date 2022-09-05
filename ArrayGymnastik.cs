using System;
using System.Collections.Generic;
using System.Text;

namespace Modul3
{
    class ArrayGymnastik
    {
        static void Main(string[] args)
        {
            //a
            Random rand = new Random();
            int[] randomArray = new int[50];
            for (int i = 0; i < randomArray.Length; i++)
            {
                int number = rand.Next(50);
                randomArray[i] = number;
                Console.WriteLine(number);
            }

            //følgende linje burde crashe programmet 
           // int test = randomArray[53];

            //b
            Console.WriteLine("Nu i modsat rækkefølge:");
            for (int j = 49; j >= 0; j--)
            {
                Console.WriteLine(randomArray[j]);
            }

            //c
            Console.WriteLine("Jeg udskriver elementerne i et givet interval, fra element nr. 14 til element nr 23");
            for (int k = 13; k < 23; k++)
            {
                Console.WriteLine(randomArray[k]);
            }

            //d
            Console.WriteLine("Jeg udskriver alle værdier mellem 10 og 20");
            foreach(int n in randomArray)
            {
                if (n > 10 && n < 20)
                {
                    Console.WriteLine(n);
                }
            }

            //e 
            Console.WriteLine("Vi udskriver antallet af forekomster af tallet 5");

            int antal = FindAntal(randomArray, 5);
            Console.WriteLine(antal);

            //f
            Console.WriteLine("Vi udskriver index til først forekommende af tallet 5");
            int index = FindForste(randomArray, 5);
            Console.WriteLine(index);





            //metodekald - returværdien gemmes i en variabel
            int resultat = Gange(3, 4);



        }



        //metode signatur
        static int Gange(int tal1, int tal2)
        {
            //returneringsværdien skal matche den returværdi signaturen indeholder
            return tal1 * tal2;
        }








        static Int32 FindAntal(Int32[] tabel, Int32 tal)
        {
            int n = 0;
            foreach(int l in tabel)
            {
                if (l == tal)
                {
                    n++;
                }
            }
            if (n == 0) n = -1; //hvis vi ikke kan finde tallet
            return n;
        }

        static Int32 FindForste(Int32[] tabel, Int32 tal)
        {
            int ret = -1;
            for (int i = 0; i<tabel.Length; i++)
            {
                if (tal == tabel[i])
                {
                    ret = i;
                    return ret; 
                    //vi kan godt stoppe forloppen her, da tallet er fundet
                }
            }
            return ret;
        }
    }
}
