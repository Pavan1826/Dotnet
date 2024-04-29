using System;
using Project;
namespace Project
{
    class B
    {
        internal protected string a 
        {
            get;
            set;
        }
    }
    class C : B
    {
        public C()
        {
            a = "Pavan";
        }
    }
}
namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            Console.WriteLine(c.a);                                                                                                   
            Console.ReadKey();
        }
    }
}
