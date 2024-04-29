using System;
using System.Runtime.InteropServices;

namespace Practice_3
{
    class F 
    {
        public int f;
        public F() 
        {
            f = 12;
        }
        public void Show()
        {
            Console.WriteLine(f);
        }
    }
    class G : F
    {
        public int g;
        public G(int c) 
        {
            g = c + 5;
        }
        public void Show1()
        {
            Console.WriteLine(g);
        }
    }
    class H : G
    {
        public int h;
        public H(int c,int h):base(c)
        {
            this.h = h;                                          
        }
        public void Show2()
        {
            Console.WriteLine(h);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            H i = new H(12, 24);
            i.Show();
            i.Show2();
            i.Show1();
        }
    }
}
