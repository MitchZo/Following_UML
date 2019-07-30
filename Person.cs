using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12
{
    abstract class Person
    {
        private string name;
        private string address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public Person()
        {

        }
        public Person(string _name, string _address)
        {
            name = _name;
            address = _address;
        }
        public override string ToString()
        {
            return $"Person [name = {Name}, address = {Address}]";
        }
        public Person SetName(Person person, string personType)
        {
            string response = "";
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine($"Please enter {personType}'s name: ");
                response = Console.ReadLine();
                if (response == "")
                {
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }
            }
            person.Name = response;
                return person;
        }
        public Person SetAddress(Person person, string personType)
        {
            Console.WriteLine($"Please enter {person.Name}'s address: ");
            person.Address = Console.ReadLine();
            return person;
        }
    }
}
