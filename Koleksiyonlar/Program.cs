using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] name = new string[] { "Kıvanç", "Onur", "Hüseyin", "Ömer", "Ahmet" };
            //Console.WriteLine(name[0]);

            List<string> name2 = new List<string> { "Kıvanç", "Onur", "Hüseyin", "Ömer", "Ahmet" };
            Console.WriteLine(name2[0]);
            Console.WriteLine(name2[1]);
            Console.WriteLine(name2[2]);
            Console.WriteLine(name2[3]);
            name2.Add("Kamil");
            Console.WriteLine(name2[4]);
            Console.WriteLine(name2[5]);
            Console.WriteLine(name2[0]);


        }
    }
}
