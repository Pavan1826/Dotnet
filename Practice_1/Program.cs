using System;

namespace Practice_1
{
    class DUDE
    {
        public string clgname;
        public string Clg
        {
            get
            {
                return clgname;
            }
            set
            {
                clgname = value;
            }
        }
    }
    class DOBU
    {
        private string[] name = new string[6];
        public string this[int i]
        {
            get
            {
                return name[i];
            }
            set
            {
                name[i] = value;
            }
        }
    }
    static class P
    {
        static int p = 56;
        static P() 
        { 
            p = p + 6; 
        }
        public static void s1() 
        {  
            Console.WriteLine(p);
        }
    }
    class Q
    {
        public int K;
        static int S = 56;
        static Q()
        {
            S = S * 2;
        }
        public static void s2()
        {
            Console.WriteLine(S);
        }
        public Q()
        {
            K = S + 2;
        }
        public void s3()
        {
            Console.WriteLine(K);
        }
    }
    enum department
    {
        IT,
        CSE,
        ME,
        CH,
        EC,
        EE
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            float b = 45.2f;
            double c = 56.56;
            char d = 'A';
            object o;
            o = a;
            o = b;
            Nullable<int> n=null;
            int? l = null;
            int r = l ?? 53;
            int j = l.GetValueOrDefault();
            var depart = (int)department.CH;
            var Depart = (department)5;
            Console.WriteLine(Depart);
            Console.WriteLine(depart);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(o);
            Console.WriteLine(n);
            Console.WriteLine(l);
            Console.WriteLine(r);
            Console.WriteLine(j);
            int? w = 30;
            int x = 20;
            if(Nullable.Compare<int>(w, x) > 0)
            {
                Console.WriteLine("More");
            }
            else if(Nullable.Compare<int>(w, x) < 0)
            {
                Console.WriteLine("less");
            }
            else
            {
                Console.WriteLine("Equal");
            }
            DUDE dUDE = new DUDE();
            dUDE.clgname = "ADIT";
            Console.WriteLine(dUDE.clgname);
            DOBU t = new DOBU();
            t[0] = "Pavan";
            t[1] = "Darshan";
            t[2] = "Hitiksha";
            t[3] = "Sahil";
            t[4] = "Palak";
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(t[i]);
            }
            Q q = new Q();
            Q.s2();
            q.s3();
            P.s1();
            Console.Read();
        }
    }
}
