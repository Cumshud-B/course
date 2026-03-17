using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Models
{
    class Teacher
    {
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Departmentname { get; set; }
        public string Subject { get; set; }
        public DateOnly Birthdate { get; set; }
        public string Address { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Teacher() { }
        //public Teacher(string username, string firstname, string lastname, string departmentname, string subject, DateOnly birthdate, string address, string phonenumber, string email, string password)
        //{
        //    this.Username = username;
        //    this.Firstname = firstname;
        //    this.Lastname = lastname;
        //    this.Departmentname = departmentname;
        //    this.Subject = subject;
        //    this.Birthdate = birthdate;
        //    this.Address = address;
        //    this.Phonenumber = phonenumber;
        //    this.Email = email;
       // dsjisww test 
        //    this.Password = password;
        //}







        //public Teacher(string Username,string Firstname, string Lastname,
        //    string Departmentname,string Subject,int Birthdate,int Address,string Phonenumber,string Email,string password)
        //{
        //    _Username = Username;
        //    _Firstname = Firstname;
        //    _Lastname = Lastname;
        //    _Departmentname = Departmentname;
        //    _Subject = Subject;
        //    _Birthdate = Birthdate;
        //    _Address = Address;
        //    _Phonenumber = Phonenumber;
        //    _Email = Email;
        //    _Password = password;


        //}
        // public Teacher(string Firstname, string Lastname,string Email, string password, string Username, string Phonenumber)
        // {
        //     _Firstname = Firstname;
        //     _Lastname = Lastname;
        //     _Email = Email;
        //     _Password = password;
        //     _Username = Username;
        //     _Phonenumber = Phonenumber;
        // }
        //public Teacher(string Firstname, string Lastname, string Email, string password, string Username, int Birthdate, string Subject)
        // {
        //     _Firstname = Firstname;
        //     _Lastname = Lastname;
        //     _Email = Email;
        //     _Password = password;
        //     _Username = Username;
        //     _Birthdate = Birthdate;
        //     _Subject = Subject;
        // }
        // public string GetName()
        // {
        //     return _Firstname + " " + _Lastname;
        // }
        // public string GetSubject()
        // {
        //     return _Subject;
        // }
        // public string GetTeacher()
        // {
        //     return _Firstname + " " + _Lastname + " " + _Email + " " + _Username;
        // }
        // public string GetEmail()
        // {
        //     return _Email;
        // }
        // public int GetBirthdate()
        // {
        //     return _Birthdate;
        // }
        // public string GetContact()
        // {
        //     return _Phonenumber + " " + _Email;
        // }
    }
    
}
