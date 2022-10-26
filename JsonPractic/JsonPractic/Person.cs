using System;
using System.Collections.Generic;
using System.Text;

namespace JsonPractic
{
    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Address Address { get; set; }
        public Person(string name, int id, string street, string state, string country)
        {
            Name = name;
            Id = id;
            Address = new Address()
            {
                Street = street,
                State = state,
                Country = country,
            };

        }
    }
}
