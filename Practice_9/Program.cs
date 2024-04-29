using System;

namespace Practice_9
{
    interface A
    {
        string Name { get; set; }
    }
    interface C
    {
        void c1();
        void c2();

        interface D 
        {
            void d1();
        }
    }
    class B : A 
    {
        private string name;

        public string Name
        {
            get 
            { 
                return name; 
            }
            set 
            { 
                name = value; 
            }
        }
    }
    class P : C,C.D 
    {
        void C.c1 ()
        {
            Console.WriteLine("This is c1 method");
        }
        void C.c2()
        {
            Console.WriteLine("This is c2 method");
        }
        void C.D.d1()
        {
            Console.WriteLine("This is is inner interface");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.Name = "Ankleshwar";
            Console.WriteLine(a.Name);
            
            C c = new P();
            c.c1();
            c.c2();

            C.D cd = new P();
            cd.d1();
            Console.ReadKey();
        }
    }
}
