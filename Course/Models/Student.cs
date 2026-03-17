using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Models
{
    class Student
    {
        string _Username;
        string _FirstName;
        string _LastName;
        byte _GroupNumber;
        DateOnly _Birthday;
        string _Adress;
        string _PhoneNumber;
        string _Email;
        string _Password;

        public Student(string Username, string FirstName, string LastName, byte GroupNumber, DateOnly Birthday, string Adress, string PhoneNumber, string Email, string Password)
        {
            _Username = Username;
            _FirstName = FirstName;
            _LastName = LastName;
            _GroupNumber = GroupNumber;
            _Birthday = Birthday;
            _Adress = Adress;
            _PhoneNumber = PhoneNumber;
            _Email = Email;
            _Password = Password;
        }
        public Student(string FirstName, string LastName, string Email, string Password, string Username, string PhoneNumber)
        {
            _Username = Username;
            _FirstName = FirstName;
            _LastName = LastName;
            _PhoneNumber = PhoneNumber;
            _Email = Email;
            _Password = Password;
        }
        public Student(string Username, string FirstName, string LastName, byte GroupNumber, DateOnly Birthday, string Email, string Password)
        {
            _Username = Username;
            _FirstName = FirstName;
            _LastName = LastName;
            _GroupNumber = GroupNumber;
            _Birthday = Birthday;
            _Email = Email;
            _Password = Password;
        }
        public string GetName()
        {
            return _FirstName + " " + _LastName;
        }
        public byte GetGroup()
        {
            return _GroupNumber;
        }
        public string GetStudent()
        {
            return _FirstName + " " + _LastName + " " + _Email + " " + _Username;
        }
        public string GetEmail()
        {
            return _Email;
        }
        public DateOnly GetBirthdate()
        {
            return _Birthday;
        }
        public string GetContact()
        {
            return _PhoneNumber + " " + _Email;
        }
    }
}
