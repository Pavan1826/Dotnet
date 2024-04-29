using System;

namespace ConsoleApp6
{
    class person
    {
        public string name;
        private int age=22;
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
        public string Surname
        {
            get;
            set;
        }
        public int Age
        {
            get
            {
                return age;
            }
        }
        private static string city;
        public static string City
        {
            get
            {
                return city;
            }
            set 
            {
                city = value;
            }
        }
    }


    class J 
    {
        private string Firstname;
        public string firstname
        {
            get
            {
                return Firstname;
            }
            set 
            {
                Firstname = value;
            }
        }
        public string Lastname
        {
            get;
            set;
        }
        private static string State;
        public static string state
        {
            get
            {
                return State;
            }
            set 
            { 
                State = value;
            }
        }
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            person obj = new person();
            obj.Name = "Pavan";
            Console.WriteLine(obj.Name);
            person obj2 = new person();
            obj2.Surname = "Jhagadiawala";
            Console.WriteLine(obj2.Surname);
            person obj3 = new person();
            Console.WriteLine(obj3.Age);
            person.City = "Delhi";
            Console.WriteLine(person.City);

            Console.WriteLine(" ");

            J myobj = new J();
            myobj.firstname = "Pavan";
            Console.WriteLine(myobj.firstname);
            J myobj2 = new J();
            myobj2.Lastname = "Jhagadiawala";
            Console.WriteLine(myobj2.Lastname);
            J.state="Gujarat";
            Console.WriteLine(J.state);
        }
    }
}
