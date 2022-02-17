using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Person
    {
        private string _name;
        private string _surname;
        private DateOnly _birthday;


        public Person(string name, string surname, DateOnly birthday)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }

        public Person():this(name:"Petro",surname:"Petrenko",birthday:new DateOnly(2001, 1, 1)) { 
        }
        public string Name
        {
            get
            {
                return _name;
            }

            init
            {
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }

            init
            {
                _surname = value;
            }
        }

        public DateOnly Birthday
        {
            get
            {
                return _birthday;
            }

            init
            {
                _birthday = value;
            }
        }

        public int Year
        {
            get
            {
                return Birthday.Year;
            }

            init
            {
  
                Birthday = new DateOnly(Birthday.Year + value, Birthday.Month, Birthday.Day);
            }
        }

        public override string ToString()
        {
            return $"Name:{Name}\nSurname: {Surname}\nBirthday: {Birthday}\n";
        }

        public string ToShortString()
        {
            return $"Name: {Name}\nSurname: {Surname}\n";
        }
    }

}
