using System;

namespace ConsoleApp7
{
    class A                                 //indexer
    {
        private string[] names = new string[10];
        public string this[int i]
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> n = null;        //Nullablecusing keyword
            int? s = null;                 //declare Nullable using ? operator
            int m = s ?? 1;  
            int d = s.GetValueOrDefault(); //Nullable using getfunction
            int? a = 25;                   //Nullable compare value
            int b = 15;
            if (Nullable.Compare<int>(a, b) < 0)
            {
                Console.WriteLine("less");
            }
            else if (Nullable.Compare<int>(a, b) > 0)
            {
                Console.WriteLine("more");
            }
            else
            {
                Console.WriteLine("equal");
            }

            A Team = new A();
            Team[0] = "Pavan";
            Team[1] = "Darshan";
            Team[2] = "Hitiksha";
            Team[3] = "Vrunda";
            Team[4] = "Viraj";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Team[i]);
            }
            Console.WriteLine(n);
            Console.WriteLine(m);
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
