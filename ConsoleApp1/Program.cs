using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        enum department
        {
            FullStack,
            Javascript,
            QA,
            DevOps
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Datatypes");
            int a = 25;
            Console.WriteLine(a);
            float b = 5.6f;
            Console.WriteLine(b);
            char c = 'a';
            Console.WriteLine(c);
            double d = 56.56;
            Console.WriteLine(d);
            string s = "Pavan";
            Console.WriteLine(s);
            Console.WriteLine(" ");
            Console.WriteLine("Using Object");
            object o;
            o = a;
            o = b;
            Console.WriteLine(o);
            Console.WriteLine(" ");
            Console.WriteLine("enum datatype");
            Console.WriteLine(department.Javascript);
            Console.WriteLine(" ");
            Console.WriteLine("Int conversion");
            int Depart = (int)department.DevOps;
            Console.WriteLine(Depart);
            Console.WriteLine(" ");
            Console.WriteLine("enum conversion");
            var depart = (department) 3;
            Console.WriteLine(depart);
            Console.WriteLine(" ");
            Console.WriteLine("Dynamic");
            dynamic e;
            e = 100;
            e = 101;
            Console.WriteLine(e);
            Console.WriteLine(" ");
            Console.WriteLine("Var");
            var f = 100;
            var x = "hi";
            Console.WriteLine(f);
            Console.WriteLine(x);
        }
    }
}
