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
            //InterfacesIntro()ü;

            //Dal();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }

        private static void Dal()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
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

            Worker worker = new Worker
            {
                Id = 1,
                FirstName = "Mehmet Ali",
                LastName = "Palta",
                Departmant = "Wood Turning"
            };
            manager.Add(student);
            manager.Add(worker);
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

    class Worker : IPerson
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

