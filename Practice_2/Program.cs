using System;

namespace Practice_2
{
    class A
    {
        public int x; 
        public int y;
        public A()
        {
            x = 45;
            y = 56;
        }
        public void show()
        {
            Console.WriteLine(x+" "+y);
        }
    }
    class B : A
    {
        public int j;
        public B(int k)
        {
            j = k+7;
        }
        public void show1()
        {
            Console.WriteLine(j);
        }
    }
    class C : B
    {
        public int p;
        public C(int p,int k):base(k)
        {
            this.p = p;
        }
        public void show2() 
        { 
            Console.WriteLine(p); 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            C c = new C(45,45);
            c.show();
            c.show1();
            c.show2();
        }
    }
}
