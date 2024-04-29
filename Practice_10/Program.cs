using System;

namespace Practice_10
{
    internal class Program
    {
        enum Animals
        {
            Dog,
            Cat,
            Horse,
            Elephant,
            Tiger,
        }
        public class P
        {
            public static int k;
            public static int l;

            static P() 
            { 
                k = 56;
                l = 57;
            }
            public static void show()
            {
                Console.WriteLine(k + " "+  l);
            }
        }
        class Q
        {
            public static int j;
            public int u;
            public int v;

            public Q()
            {
                u = 15;
                v = u + j;

            }
            static Q()
            {
                j = 20;
            }
            public void s1()
            {
                Console.WriteLine(u + " " + v);
            }
            public static void show()
            {
                Console.WriteLine(j);
            }
        }
        static void Main(string[] args)
        {
            var animals = Animals.Dog;
            var ani = (int) Animals.Cat;
            var animal = (Animals)3;
            Nullable<int> a = null;
            int? b = 45;
            int c = b ?? 56;
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(animal);
            Console.WriteLine(ani);
            Console.WriteLine(animals);
            Q q = new Q();
            q.s1();
            Q.show();
            P.show(); 
            
            Console.ReadKey();
        }
    }
}
