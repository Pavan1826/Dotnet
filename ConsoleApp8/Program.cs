using System;

namespace ConsoleApp8
{
    class A             //inheritance
    {
        public int a; 
        public A() 
        {
            a = 16;
        }
    }
    class B : A
    {
        public int b;
        public B() 
        {
            b = 45;    
        }
    }
    class C : B
    {
        public int c;
        public C()
        {
            c = a + b;
        }
        public void method()
        {
            Console.WriteLine(a + " " + b + " " + c);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            C c1 = new C();
            c1.method();

        }
    }
}
