using System;

namespace Practice_4
{
    class Person
    {
        public string con;
        public string name;

        public Person() 
        {
            con = "456-456";
            name = "Pavan";
        }
        public virtual void getinfo()
        {
            Console.WriteLine(con);
            Console.WriteLine(name);
        }
    }
    class Employee : Person
    {
        public int id;
        public Employee() 
        { 
            id = 1; 
        }
        public override void getinfo() 
        {
            base.getinfo();
            Console.WriteLine(id); 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Employee e = new Employee();
            e.getinfo();
        }
    }
}
