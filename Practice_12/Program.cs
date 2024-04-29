using System;
using PATA = Practice_12.ProjectA;
using PATB = Practice_12.ProjectB;

namespace Practice_12
{
    namespace ProjectA
    {
        class ClassA
        {
            public static void print()
            {
                Console.WriteLine("team A print method");
            }

        }
    }
}
namespace Practice_12
{
    namespace ProjectB
    {
        class ClassA
        {
            public static void print()
            {
                Console.WriteLine("team B print method");
            }

        }
    }
}
internal class Program
    {
        static void Main(string[] args)
        {
            PATA.ClassA.print();
            PATB.ClassA.print();
            Console.ReadKey();
        }
    }

