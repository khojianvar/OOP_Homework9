using System.Net;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudents = new List<Student>();
            listStudents.Add(new Student(1, "dafa", "safdas"));
            listStudents.Add(new Student(2, "sdafa", "asafdas"));
            foreach (Student student in listStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
    class Student 
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public Student(int id, string fullName, string phoneNumber) 
        {
            Id = id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
    }
    class Group 
    {
        public Student student { get; set; }
    }
}