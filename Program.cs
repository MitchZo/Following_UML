using System;
using System.Collections.Generic;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person> {
            new Student ("communications", 10000.50, 4, "Theodore", "123 Fake st. AnyTown, USA"),
            new Student ("Economics", .50, 6, "Bernice", "742 Evergreen Terrace, Springfield, USA"),
            new Student ("TV/VCR repair", 842.95, 26, "Al", "452 Park Place Falls, Twin Peaks, Canada"),
            new Staff ("Bennie Elementary", 450000.82, "Mrs. Carmichael", "566 Nunya, Bizanhus, Cambodia"),
            new Staff ("University of Bangladesh", 543.52, "Mr. Feeney", "222 Ripley Dr, Bermuda, Mexico")};
            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString()+"\n");
            }

            AddPersonToList(people);
            PrintList(people);
        }
        public static Person AddPerson()
        {
            string response = "";
            bool isValid = false;
            Student newStudent = new Student();
            Staff newStaff = new Staff();
            string newPerson = "";

            while (!isValid)
            {
                Console.WriteLine("Would you like to add a new Student or Faculty Member?");
                response = Console.ReadLine();

                if (response.ToLower() == "student")
                {
                    newPerson = "student";
                    isValid = true;
                }
                else if (response.ToLower() == "faculty member" || response.ToLower() == "staff")
                {
                    newPerson = "staff";
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }
                if (newPerson == "student")
                {
                    newStudent.SetName(newStudent, "student");
                    newStudent.SetAddress(newStudent, "student");
                    newStudent.SetFee(newStudent);
                    newStudent.SetProgram(newStudent);
                    newStudent.SetYear(newStudent);
                }
                if (newPerson == "staff")
                {
                    newStaff.SetName(newStaff, "staff");
                    newStaff.SetAddress(newStaff, "staff");
                    newStaff.SetPay(newStaff);
                    newStaff.SetSchool(newStaff);
                }
            if(newPerson == "student")
            {
                return newStudent;
            }
            else
            {
                return newStaff;
            }
        }
        public static List<Person> AddPersonToList(List<Person> people)
        {
            people.Add(AddPerson());
            return people;
        }
        public static void PrintList(List<Person> people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
