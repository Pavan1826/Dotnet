using System;

namespace Practice_7
{
    public partial class Myclass
    {
        public void method() 
        {
           
        }
    }
    abstract class D
    {
        public abstract void print();

        public void show()
        {
            Console.WriteLine("This is Abstact Class");
        }
    }
    class X : D
    {
        
        public override void print()
        {
            Console.WriteLine("This X abstact class");
        }
        public virtual void show() 
        {
            Console.WriteLine("This is Base class");
        }
    }
    class Y : X
    {
        public int h;

        public Y(int i)
        {
            h = i + 8;
        }
        public override void print()
        {
            Console.WriteLine("This Y abstarct class");
        }
        public override void show()                         //if use new base class print
        {
            Console.WriteLine(h);
            Console.WriteLine("This is Derived class");
        }
    }
    class Z : Y
    {
        public int k;
        public Z(int i,int k) : base(i)
        {
            this.k = k;
        }
        public override void print()
        {
            Console.WriteLine("This Z abstarct class");
        }
        public new void show()                         //if use overide that class base class is called
        { 
            Console.WriteLine(k);
            Console.WriteLine("This z Derived class");
        }
    }
    public partial class Myclass
    {
        public void method1() 
        {
            Console.WriteLine("This is Partial Class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            X x = new X();
            Y y = new Y(20);
            Z z = new Z(15,20);

            Console.WriteLine(" ");
            x.show();
            y.show();
            z.show();

            Console.WriteLine(" ");
            x.print();
            y.print();
            z.print();

            Console.WriteLine(" ");
            D d = new X();
            d.show();
            d.print();

            Console.WriteLine(" ");
            D d1 = new Y(20);
            d1.show();
            d1.print();

            Console.WriteLine(" ");
            D d2 = new Z(15,20);
            d2.show();
            d2.print();

            Console.WriteLine(" ");
            X w = x;
            w.show();

            Console.WriteLine(" ");
            w = y;
            w.show();

            Console.WriteLine(" ");
            w = z;
            w.show();
            Console.WriteLine(" ");

            Myclass n = new Myclass();
            n.method1();

            Console.ReadKey();
        }
    }
}
