using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12
{
    class Student : Person
    {
        private string program;
        private double fee;
        private int year;

        private string Program
        {
            get { return program; }
            set { program = value; }
        }
        public double Fee
        {
            get { return fee; }
            set { fee = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Student()
        {

        }
        public Student(string _program, double _fee, int _year, string name, string address)
            : base(name, address)
        {
            program = _program;
            fee = _fee;
            year = _year;
        }
        public override string ToString()
        {
            return $"Staff[Person[name={Name},address={Address}],program={Program},year={Year},fee={Fee}]";
        }
        public Student SetProgram(Student student)
        {
            Console.WriteLine($"Please enter {student.Name}'s program");
            student.Program = Console.ReadLine();
            return student;
        }
        public Student SetFee(Student student)
        {
            string response = "";
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine($"Please enter {student.Name}'s tuition fee: ");
                response = Console.ReadLine();
                if (int.TryParse(response, out int results))
                {
                    isValid = true;
                    student.Fee = (int.Parse(response));
                }
                else
                {
                    isValid = false;
                }
            }

            return student;
        }
        public Student SetYear(Student student)
        {
            string response = "";
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine($"Please enter how many years {student.Name} has been in school: ");
                response = Console.ReadLine();
                if (int.TryParse(response, out int results))
                {
                    isValid = true;
                    student.Year = (int.Parse(response));
                }
                else
                {
                    isValid = false;
                }
            }

            return student;
        }
    }
}
