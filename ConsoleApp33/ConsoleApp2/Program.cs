using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Patient
    {
        public Patient() { }
        private string _name;
        private int _age;
        private string _gender;
        private string _country;

        public string Name 
        { 
            get 
            { 
                return _name; 
            } 
            set 
            { 
                _name = value;
            } 
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public string Gender
        {
            get 
            { 
                return _gender;
            }
            set 
            {
                _gender = value;
            }
        }
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Patient> list = new List<Patient>();
            Patient patient = new Patient();
            patient.Name = "Pavan";
            patient.Age = 22;
            patient.Gender = "Male";
            patient.Country = "India";
            list.Add(patient);
            var list1 = from pa in patient
                        where pa.Age == 22
                        select pa;
            foreach (var pat in list)
            {
                Console.WriteLine(pat.Name + "" + pat.Gender + "" + pat.Country);
            }


            Console.ReadKey();
        }
    }
}
