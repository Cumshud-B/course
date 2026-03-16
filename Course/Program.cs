using Course.Models;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("hemid", "eliyev", "faffg", "678", "ara", "050");
            Console.WriteLine(teacher.GetName());
        }
    }
}
