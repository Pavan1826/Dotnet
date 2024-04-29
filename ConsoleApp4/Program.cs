using System;

namespace ConsoleApp4
{
    static class A
    {
        static int a = 15;
        static int b ;
        static A()
        {
            b = a + 9;
        }
        public static void B()
        {
            Console.WriteLine(A.b);
        }
    }
    class C
    {
        static int x = 1;
        static int z = 5;
        int y;
        public C()
        {
            Console.WriteLine("This is constructer");
        }

        static C()
        { 
            Console.WriteLine(x); 
        }
        public static void method()
        {
            x = x + z;
            Console.WriteLine(x);
        }
        public void method2(int y)
        {
            Console.WriteLine(y);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A.B();
            C c = new C();
            C.method();
            C d = new C();
            d.method2(10);
            Console.ReadLine(); 
        }
    }
}
