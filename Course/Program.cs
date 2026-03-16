using Course.Models;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Jumshud", "Bakhtiyarli", "baktiyarli2006@gmail.com", "player123", "Cumsud", "+994 10 215 2006");
            Console.WriteLine(student.GetName());

            Student student1 = new Student("hemid", "Hamid", "Aliyev", "682a1", new DateOnly(2005, 03, 22), "hamidaliyev@gmail.com", "hamid123");
            Console.WriteLine(student1.GetStudent());


            //Student student2 = new Student()
        }
    }
}
