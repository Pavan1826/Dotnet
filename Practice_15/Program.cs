using System;
using project;

namespace Practice_15
{
    class D : project.A
    {
        public D() 
        {
            k = 67;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.i);
            Console.WriteLine(a.k);
            a.view();

            Console.ReadKey();
        }
    }
}
