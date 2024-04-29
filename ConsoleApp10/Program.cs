using System;

namespace ConsoleApp10
{
    interface A
    {
        void f1();
        void f2();

        interface P
        {
            void f3();
        }
    }
    interface D
    {
        void d1();
    }
    class B : A,D,A.P
    {
        void A.f1() 
        {
            Console.WriteLine("This is f1 method of interface");
        }
        void A.f2() 
        {
            Console.WriteLine("This is f2 method of interface");
        }
        void D.d1() 
        { 
            Console.WriteLine("This is another interface method");
        }
        void A.P.f3 ()
        {
            Console.WriteLine("This is inner interface");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.f1();
            a.f2();

            A.P ap = new B();
            ap.f3();
            
            D d = new B();
            d.d1();
            Console.ReadKey();
        }
    }
}
