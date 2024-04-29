using System;
using System.Security.Cryptography;
using static ConsoleApp1.P;

namespace ConsoleApp1
{
    class P 
    {
        public delegate void delmethod();
        public delegate void delmethod1(int i, int j);
        public static void display()
        {
            Console.WriteLine("Hello");
        }
        public static void show()
        {
            Console.WriteLine("Hi");
        }
        public void print()
        {
            Console.WriteLine("Print");
        }
        public void addition(int i,int j)
        {
            Console.WriteLine("Addition:");
            Console.WriteLine(i + j);
        }
        public void subtraction(int i,int j)
        {
            Console.WriteLine("Subtraction:");
            Console.WriteLine(i - j);
        }
        
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            delmethod del1 = P.show;
            delmethod del2 = new delmethod(P.display);
            P obj = new P();

            obj.print();

            del1();
            del2();

            P obj1 = new P();
            delmethod1 del = new delmethod1(obj1.addition);

            del += new delmethod1(obj1.subtraction);
            del(45, 50);
            Console.WriteLine();

            del -= new delmethod1(obj1.addition);
            del(50, 45);


            Console.ReadKey();
        }
    }
}
