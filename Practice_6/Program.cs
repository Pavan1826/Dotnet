using System;

namespace Practice_6
{
    class C
    {
        private int a;
        private int b;
        public C() 
        {

        }
        public C(int i, int j)
        {
            a = i; 
            b = j;
        }
        public void show()
        {
            Console.WriteLine("a= "+ a +" "+ "b= " + b);
        }
        public static C operator -(C c)     //Unary Operator
        {
            C temp = new C();
            temp.a = -c.a;
            temp.b = -c.b;
            return temp;
        }
        public static C operator +(C t,C s)  // Binary Operator
        {
            C temp = new C();
            temp.a = t.a + s.a;
            temp.b = t.b + s.b;
            return temp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            C c1 = new C(15,20);
            c1.show();
            C c2 = new C();
            c2 = -c1;
            Console.WriteLine("Unary operator");
            c2.show();
            C t = new C(21,21);
            t.show();
            C s = new C(29,29);
            s.show();
            Console.WriteLine("Binary operator");
            C x = new C();
            x = t + s;
            x.show();
        }
    }
}
