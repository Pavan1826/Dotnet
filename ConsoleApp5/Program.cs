using System;

namespace ConsoleApp5
{
    static class G { 
        static int j = 23;
        static int h;
        static G()
        {
            h = j + 25;
        }
        public static void KL()
        {
            Console.WriteLine(G.h);
        }
    }
    class P
    {
        static int c = 50;
        static int d = 50;
        int e;
        static P()
        {
            d = c * d;
        }
        public static void S()
        {
            Console.WriteLine(P.d);
        }
        public P()
        {
            e = c + 2;
        }
        public void Q()
        {
            Console.WriteLine(e);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            P p = new P();
            p.Q();
            P.S();
            G.KL();
        }
    }
}
