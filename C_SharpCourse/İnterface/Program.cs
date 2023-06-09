﻿using System;

namespace İnterface
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 2, FirstName = "Ayşe", LastName = "Fatma" ,Address="Ankara"});

            //şöyle de olabilir
            //Customer customer = new Customer
            //{
            //    Id = 2,
            //    FirstName = "Ayşe",
            //    LastName = "Fatma",
            //    Address = "Ankara"

            //};
            //manager.Add(customer);

            Student student = new Student
            {
                Id = 3,
                FirstName = "Duygu",
                LastName = "Demir",
                Departmant = "Computer Engineering"

            };
            manager.Add(student);



            Console.ReadLine();
            
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }

        }
    }
}
