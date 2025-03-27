using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_practicum
{
    abstract class Person
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public abstract void PrintInfo();
        //переделать метод 
        //public int GetAge()
        //{
        //    DateTime now = DateTime.Now;
        //    DateTime age = now.Year - DateOfBirth.Year;
        //    return age;
        //}

    }
}
