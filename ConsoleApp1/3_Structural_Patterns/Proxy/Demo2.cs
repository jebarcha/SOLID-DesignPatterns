using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Proxy
{
    public class Demo2
    {
    }
    public class Person
    {
        public Person(int balance)
        {
            Balance = balance;
        }

        public int Balance { get; set; }

        public string Eat()
        {
            return "Eating";
        }

    }

    public class ProxyPerson
    {
        private readonly Person person;

        public ProxyPerson(Person person)
        {
            this.person = person;
        }

        public string Eat()
        {
            if (person.Balance > 0)
                return person.Eat();
            return "the person does not have money";
        }


    }

}
