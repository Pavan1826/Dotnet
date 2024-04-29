using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    class D
    {
        public D()
        {
            Console.WriteLine("This is Constructer");
        }
        public void Show(params int[] d1)
        {
            for (int i = 0; i < d1.Length; i++)
            {
                Console.WriteLine(d1[i]);
            }
        }
        public void add(params int[] d)
        {
            foreach (int i in d)
                Console.WriteLine(i);
        }
        public void ch(params char[] e) {
            foreach (char j in e)
                Console.WriteLine(j);
        }
    }
    
    enum Fruits
    {
        Apple,
        Banana,
        Jackfruit,
        WaterMelon,
        Grapes
    }

    public class Students
    {
        
    }
    internal class Program
    {
        public static void addvalue(ref int x)
        {
            x++;
            Console.WriteLine(x);
        }
        public static void Out1(out int y)
        {
            y = 6;
            y++;  
            Console.WriteLine(y);
        }
        static void Main(string[] args)
        {
            int[] a=new int [5];
            for(int i=0;i<a.Length;i++)
            {
                a[i]=Convert.ToInt16(Console.ReadLine()); 
            }
            for(int i = 0;i<a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            int[,] c = new int[2,2];
            for(int i = 0; i < c.GetLength(0); i++)
            {
                for(int j = 0; j < c.GetLength(1); j++)
                {
                    c[i,j]=Convert.ToInt16(Console.ReadLine());
                }
            }
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.WriteLine(c[i,j]);
                }
            }
            int Fruit = (int)Fruits.Banana;
            Console.WriteLine(Fruit);
            var fruit = (Fruits)2;
            Console.WriteLine(fruit);

            D d = new D();
            D d1 = new D();
            d1.Show(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            d1.Show(6, 7, 8);
            d1.Show(9, 10);
            D d2 = new D();
            d2.add(1, 2, 3);
            d2.add(23, 24, 25, 26, 27);
            int x = 5;
            addvalue(ref x);
            int y;
            Out1(out y);
        }
    }
}
