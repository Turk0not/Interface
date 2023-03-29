using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Mustafa",
                LastName = "Palta",
                Address = "Bursa"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Mehmet Ali",
                LastName = "Palta",
                Departmant = "Computer Sciences"
            };
            manager.Add(student);
            manager.Add(customer);
            Console.ReadLine();
        }
    }

    interface IPerson
    {
        int Id
        {
            get; set;
        }

        String FirstName
        {
            get; set;
        }

        string LastName
        {
            get; set;
        }
    }

    class Customer : IPerson
    {
        public int Id
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }

        public string LastName
        {
            get; set;
        }

        public string Address
        {
            get; set;
        }
    }

    class Student : IPerson
    {
        public int Id
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }

        public string LastName
        {
            get; set;
        }

        public string Departmant
        {
            get; set;
        }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

