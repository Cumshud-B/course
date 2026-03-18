using Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Course.Actions
{
       public static class Register
    {
            static List<Teacher> teachers = new List<Teacher>();
            public  static void RegisterTeacher(Teacher  teacher)
        {
            teachers.Add(teacher);
             foreach(var item in teachers)
            {
                Console.WriteLine($"{item.Firstname}-{item.Lastname}");
            }
            Console.WriteLine();
        }
        public static void Login(string Email,string Password)
        {
            Teacher teacher = teachers.FirstOrDefault(t => t.Email == Email && t.Password == Password);
            if(teacher != null) Console.WriteLine("Giris ugurludur!");
            else
            {
                Console.WriteLine("Email ve ya sifre yalnisdir!");
            }
        }
        
    }
}
