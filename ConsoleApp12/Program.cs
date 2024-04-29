using System;

namespace ConsoleApp12
{
    struct Coordinate   //create simple struct
    {
        public int x;
        public int y;
    }

    struct Coordinate2  //parameterised constructer
    { 
        public int a; 
        public int b; 

        public Coordinate2(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }

    struct Coordinate3  //property and method
    {
        public int p
        {
            get;
            set;
        }
        public int q
        { 
            get; 
            set; 
        }
        public void origin()
        {
            this.p = 45;
            this.q = 50;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Coordinate point;
            point.x = 50;
            point.y = 75;
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
            Console.WriteLine(" ");
            Coordinate2 point2 = new Coordinate2(20,50);
            Console.WriteLine(point2.a);
            Console.WriteLine(point2.b);
            Console.WriteLine(" ");
            Coordinate3 point3 = new Coordinate3();
            point3.origin();
            Console.WriteLine(point3.p);
            Console.WriteLine(point3.q);
            Console.ReadKey();
        }
    }
}
