using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] isimler = new string[] { "Furkan", "Eda", "Necati", "Taylan" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            List<string> isimler2 = new List<string> { "Furkan", "Eda", "Necati", "Taylan" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);

        }
    }
}
