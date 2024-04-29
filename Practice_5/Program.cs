using System;

namespace Practice_5
{
    class Uni
    {
        public string Universityname;
        public Uni() 
        {
            Universityname = "CVM";
        }

        public virtual void info()
        {
            Console.WriteLine(Universityname);
        }
    }
    class Clg : Uni
    {
        public string clgname;
        public Clg() 
        {
            clgname = "ADIT";
        }
        public override void info() 
        { 
            
            Console.WriteLine(clgname); 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Uni c = new Uni();
            Clg a = new Clg();

            Uni b = c;
            b.info();

            b = a;
            b.info();

        }
    }
}
