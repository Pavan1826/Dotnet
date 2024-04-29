using System;

namespace Practice_8
{
    abstract class Car
    {
        public abstract void method();

        public void show()
        {
            Console.WriteLine("This is abstarct class");
        }
    }
    class Innova : Car
    {
        public override void method()
        {
            Console.WriteLine("This is Innova's abstact class");
        }
        public virtual void show()
        {
            Console.WriteLine("This is derived class");
        }
    }
    class Liva : Innova
    {
        public override void method()
        {
            Console.WriteLine("This is Liva's abstract class");
        }
        public sealed override void show()
        {
            Console.WriteLine("This is Innova's derived class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Innova i = new Innova();
            i.method();
            i.show();

            Car c = new Innova();
            c.method();

            Liva l = new Liva();
            l.method();
            l.show();
            Console.ReadKey();
        }
    }
}
