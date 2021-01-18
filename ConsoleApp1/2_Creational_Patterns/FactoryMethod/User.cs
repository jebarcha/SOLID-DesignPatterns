using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns.FactoryMethod
{
    public class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Country { get; private set; }

        private User(string name, string email, string country = "Mexico")
        {
            Name = name;
            Email = email;
            Country = country;
        }
        public static class Factory
        {
            public static User CreateWithDefaultCountry(string name, string email)
            {
                return new User(name, email, "Mexico");
            }
            public static User CreateWithDefaultEmail(string name, string country)
            {
                return new User(name, "defaultemail@email.com", country);
            }
        }
    }
}
