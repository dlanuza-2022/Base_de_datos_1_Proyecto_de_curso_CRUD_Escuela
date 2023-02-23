using CRUD_MySQL.misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MySQL.model.dol
{
    public enum Gender { FEMALE  , MALE }

    abstract public class Person
    {

        


        protected Person()
        {
            UUID = Guid.NewGuid();

        }

     

        public string getFullName()
        {
            return firstName + " " + middleName + " " + surname + " " + secondSurname;
        }



       





        private Guid UUID;



        //Full name
        private string firstName;
        private string middleName;
        private string surname;
        private string secondSurname;


        //Address
        private Address address;

        //Birthday
        private DateTime birthDay;
        private uint age;

        //Gender
        private Gender gender;


        //Contact info
        private string phoneNumber;
        private string landlinePhone;
        private string email;

        //Log in info
        private string userName;
        private string password;



        public string FirstName { get => firstName; set => firstName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string Surname { get => surname; set => surname = value; }
        public string SecondSurname { get => secondSurname; set => secondSurname = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public uint Age { get => age; set => age = value; }
        public Gender Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public Guid UUID1 { get => UUID; set => UUID = value; }
        public string LandlinePhone { get => landlinePhone; set => landlinePhone = value; }
 
    }
}
