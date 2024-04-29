using System;
using System.Net.Security;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Operation");
            string a = "Good Morning";  //uses string keyword
            Console.WriteLine(a);
            String ch = "Pavan";        //uses system.string class
            Console.WriteLine(ch);
            Console.WriteLine(" ");
            Console.WriteLine("String as char Array");
            char[] b = { 'a', 'b', 'c' };
            string ch2 = new string(b);
            String ch3 = new String(b);
            foreach (char c in ch2)
                Console.WriteLine(c);
            Console.WriteLine(" ");
            Console.WriteLine("Special Character");
            string text = "This is \".net\" specialization class";
            Console.WriteLine(text);
            string str = "abcd\\efg";
            Console.WriteLine(str);
            Console.WriteLine(" ");
            Console.WriteLine("Verbatim String");
            string f = @"abcd\efg";
            string g = @"\mypc\sharedproject";
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine("Multiline");
            string i = @"This is a
                     Multiline string";
            string h = @"This is a ""String"" in c#";
            Console.WriteLine(i);
            Console.WriteLine(h);

            Console.WriteLine(" ");
            Console.WriteLine("Concatenation");
            string j = "Mr." + "Pavan" + " Jhagadiawala" + ", code:007";

            string firstname = "Pavan";
            string lastname = "Jhagadiawala";
            string code = "007";

            string agent = "Mr." + firstname + " " + lastname + ", code:" + code;

            Console.WriteLine(j);
            Console.WriteLine(agent);

            Console.WriteLine(" ");
            Console.WriteLine("Interpolation");
            string k = $"Mr.{firstname} {lastname}, code:{code}";
            Console.WriteLine(k);

            Console.WriteLine(" ");
            Console.WriteLine("String Builder");
            Console.WriteLine("String Buider Iteration");
            StringBuilder sb = new StringBuilder("Hello");
            for (int o = 0; o < sb.Length; o++)
                Console.Write(sb[o]);
            Console.WriteLine(" ");
            Console.WriteLine("Retrive String from String Builder");
            var greet = sb.ToString();
            Console.WriteLine(greet);
            Console.WriteLine("Append in String Builder");
            StringBuilder ab = new StringBuilder();
            ab.Append("Hello ");
            ab.AppendLine(k);
            Console.WriteLine(ab);
            Console.WriteLine("Append Formated String to StringBuilder");
            StringBuilder sbamount = new StringBuilder("Total Price: ");
            sbamount.AppendFormat("{0:C} ", 25); 
            Console.WriteLine(sbamount);
            Console.WriteLine("Insert String into StringBuilder");
            sb.Insert(5, " C#");
            Console.WriteLine(sb);
            Console.WriteLine("Remove String in StringBuilder");
            sb.Remove(2,1);
            Console.WriteLine(sb);
            Console.WriteLine("Replace String in StringBuilder");
            sb.Replace("C#", " World");
            Console.WriteLine(sb);
        }
    }
}
