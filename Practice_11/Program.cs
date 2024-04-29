using System;

namespace Practice_11
{
    class A
    {
        public int i;

        public A(int j) 
        {
            i = j + 56;
        }
        public void show1()
        {
            Console.WriteLine(i);
        }
    }
    class B : A 
    {
        public int h;
        
        public B(int j,int h) : base(j)
        {
            this.h = h;
        }
        public void show2()
        {
            Console.WriteLine(h);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B(45, 45);
            b.show2();
            b.show1();
            Console.ReadKey();
        }
    }
}
