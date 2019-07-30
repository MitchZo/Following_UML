using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12
{
    class Staff : Person
    {
        private string school;
        private double pay;

        private string School
        {
            get { return school; }
            set { school = value; }
        }
        public double Pay
        {
            get { return pay; }
            set { pay = value; }
        }
        public Staff()
        {

        }
        public Staff(string _school, double _pay, string name, string address)
            :base (name,address)
        {
            school = _school;
            pay = _pay;
        }

        public override string ToString()
        {
            return $"Staff[Person[name={Name},address={Address}],school={School},pay={Pay}]";
        }
        public Staff SetSchool(Staff staff)
        {
            Console.WriteLine($"Please enter {staff.Name}'s school: ");
            staff.School = Console.ReadLine();
            return staff;
        }
        public Staff SetPay(Staff staff)
        {
            string response = "";
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine($"Please enter {staff.Name}'s salary: ");
                response = Console.ReadLine();
                if (int.TryParse(response,out int results))
                {
                    isValid = true;
                    staff.Pay = (int.Parse(response));
                }
                else
                {
                    isValid = false;
                }
            }
            return staff;
        }
    }
}
