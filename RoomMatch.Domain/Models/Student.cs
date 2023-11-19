using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomMatch.Domain.Models
{
    public class Student : DomainObject
    {
        public string Firstname
        {
            get { return Get<string>(); }
            set { Set<string>(value); }
        }

        public string Lastname
        {
            get { return Get<string>(); }
            set { Set<string>(value); }
        }

        public int Age
        {
            get { return Get<int>(); }
            set { Set<int>(value); }
        }

        //represents the gender of the Student
        //May be we can put the gender property in a enum{male, female, others}
        public string Gender
        {
            get { return Get<string>(); }
            set { Set<string>(value); }
        }

        //represents the field of study or specialization that the student is pursuing(ex: computer science)
        public string Major
        {
            get { return Get<string>(); }
            set { Set<string>(value); }
        }

        // Add more properties as needed...

        // Constructor to initialize these properties 
        public Student(string firstname, string lastname, int age, string gender, string major)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Gender = gender;
            Major = major;
        }
    }
}

