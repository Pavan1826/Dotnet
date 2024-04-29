using System;
using project;

namespace project
{
    public class A
    {
        public int i = 3;
        private int j = 7;
        protected int d = 6;
        internal protected int k;

        public static void View()
        {
            Console.WriteLine("Hello i am class A method");
        }
    }
    public class C
    {
        internal protected int I
        {
            get;
            set;
        }
    }
}
namespace Practice_14
{
    class B : C
    {
        public B()
        {
            I = 78;
        }
        public static void View(int I)
        {
            Console.WriteLine("This is internal protected variable: "+ I);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.i);
            Console.WriteLine(a.k);
            //Console.WriteLine(a.j); gives error private
            //Console.Writeline(a.d); gives error protected

            B b = new B();
            Console.WriteLine(b.I);
            Console.ReadKey();
        }
    }
}
