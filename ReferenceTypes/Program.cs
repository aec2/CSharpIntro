﻿using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //// int, decimal, float, enum, boolean value types
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 100;

            //Console.WriteLine("Sayı 1 : " + sayi1);

            //// arrays, class, interface... reference types
            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 1, 2, 3 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayılar1[0] = " + sayilar1[0]);
            
            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Enes";
            person2 = person1;
            person1.FirstName = "Derin";
            //Console.WriteLine("Person2 = " + person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumer = "132131245";
            Employee employee = new Employee();


            Person person3 = customer;
            //// Boxing yapıldı
            //Console.WriteLine(((Customer)person3).CreditCardNumer);
            PersonManager personManager = new PersonManager();
            personManager.Add(person1);
            personManager.Add(customer);
            personManager.Add(employee);
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        //base class : Person
        class Customer:Person
        {
            public string CreditCardNumer { get; set; }
        }

        class Employee:Person
        {
            public int EmployeeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}