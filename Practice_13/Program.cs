using System;
using TeamA;

namespace TeamA
{
    class A
    {
        public int i;
        public int j;

        public A(int i, int j)
        {
            this.i = i;
            this.j = j;
        }
    }
    class B
    {
        private int i;

        public B()
        {
            i = 16;
        }
        public int getI()
        {
            return i;
        }
    }

    class C
    {
        protected int i;

        public C()
        {
            i = 45;
        }
        public int getK()
        {
            return i;
        }
    }
}
namespace Practice_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A(45,45);
            Console.WriteLine(a.i + " " + a.j);
            B b = new B();
            Console.WriteLine(b.getI());
            C c = new C();
            Console.WriteLine(c.getK());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}