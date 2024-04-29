using System;

namespace ConsoleApp11
{
    interface account        //property in interface
    {
        string Name { get; set; }
    }
    class bank : account 
    {
        private string name { get; set; }

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

    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new bank();
            account.Name = "SBI";
       
            Console.WriteLine(account.Name);
            Console.ReadKey();
        }
    }
}
