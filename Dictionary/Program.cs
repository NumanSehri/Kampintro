using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> anahtar = new Dictionary<int, string>();
            anahtar.Add(1, "Numan");
            anahtar.Add(2, "Arif");

            foreach (var item in anahtar.Values)
            {
                Console.WriteLine(item);
            }

            Dictinor<int,string> dictinor = new Dictinor<int,string>();
            



        }
    }

    public class Dictinor<key,value>

    {
        public void Add(ke)
        {

        }
    }
}
