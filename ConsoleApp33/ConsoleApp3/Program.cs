using System;
using System.Collections;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            string str = "Pavan Jhagadiawala";
            int x = 7;
            DateTime d = DateTime.Parse("1-feb-2002");
            a1.Add(str);
            a1.Add(x);
            a1.Add(d);

            foreach (object o in a1)
            {
                Console.WriteLine(o);
                Console.WriteLine("");
            }

            Hashtable ht = new Hashtable();
            ht.Add("Pav", "Pavan");
            ht.Add("Dar", "Darshan");

            foreach(DictionaryEntry k in ht)
            {
                Console.WriteLine(k.Key + " " + k.Value);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
