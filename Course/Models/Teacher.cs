using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Models
{
    class Teacher
    {
        string _Username;
        string _Firstname;
        string _Lastname;
        string _Departmentname;
        string _Subject;
        int _Birthdate;
        int _Address;
        string _Phonenumber;
        string _Email;
        string _Password;
        public Teacher(string Username,string Firstname, string Lastname,
            string Departmentname,string Subject,int Birthdate,int Address,string Phonenumber,string Email,string password)
        {
            Username = _Username;
            Firstname = _Firstname;
            Lastname = _Lastname;
            Departmentname = _Departmentname;
            Subject = _Subject;
            Birthdate = _Birthdate;
            Address = _Address;
            Phonenumber = _Phonenumber;
            Email = _Email;
            password = _Password;


        }
        public Teacher(string Firstname, string Lastname,string Email, string password, string Username, string Phonenumber)
        {
            Firstname = _Firstname;
            Lastname = _Lastname;
            Email = _Email;
            password = _Password;
            Username = _Username;
            Phonenumber = _Phonenumber;
        }
        public Teacher(string Firstname, string Lastname, string Email, string password, string Username, int Birthdate, string Subject)
        {
            Firstname = _Firstname;
            Lastname = _Lastname;
            Email = _Email;
            password = _Password;
            Username = _Username;
            Birthdate = _Birthdate;
            Subject = _Subject;
        }
        public string GetName()
        {
            return _Firstname + " " + _Lastname;
        }
        public string GetSubject()
        {
            return _Subject;
        }
        public string GetTeacher()
        {
            return _Firstname + " " + _Lastname + " " + _Email + " " + _Username;
        }
        public string GetEmail()
        {
            return _Email;
        }
        public int GetBirthdate()
        {
            return _Birthdate;
        }
        public string GetContact()
        {
            return _Phonenumber + " " + _Email;
        }
    }
    
}
