using System;

namespace ConsoleApp9
{
    class D
    {
        public virtual void show() 
        {
            Console.WriteLine("I am base class");
        }
    }
    class A : D
    {
        public override void show() 
        { 
            Console.WriteLine("I am derived class");
        }
    }
    class R : A
    {
        public new void show()
        {
            Console.WriteLine("I am derived R method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            A a = new A();
            R r = new R();

            D k = d;
            k.show();
            k = a;
            k.show();
            k = r;
            k.show();
        }
    }
}
