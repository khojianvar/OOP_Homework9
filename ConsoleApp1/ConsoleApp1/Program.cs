using System.Net;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudents = new List<Student>();
            Console.ForegroundColor = ConsoleColor.Blue;
            listStudents.Add(new Student(1, "Abdulloh", "+998 99 815 25 65"));
            listStudents.Add(new Student(2, "Anvar", "+998 94 615 10 06"));
            listStudents.Add(new Student(3, "Ahrorbek", "+998 91 479 58 74"));
            listStudents.Add(new Student(4, "Asadbek", "+998 94 442 25 44"));
            listStudents.Add(new Student(5, "Ergash", "+998 97 470 69 96"));
            listStudents.Add(new Student(6, "Avazbek", "+998 90 202 12 32"));
            listStudents.Add(new Student(7, "Azamat", "+998 97 742 64 85"));
            listStudents.Add(new Student(8, "Aziz", "+998 93 146 99 46"));
            listStudents.Add(new Student(9, "Diyor", "+998 91 214 61 22"));
            listStudents.Add(new Student(10, "Humoyunmirzo", "+998 90 536 77 32"));
            listStudents.Add(new Student(11, "Dilshodbek", "+998 93 533 12 75"));
            listStudents.Add(new Student(12, "Nurbek", "+998 99 526 46 64"));
            listStudents.Add(new Student(13, "Quvonshbek", "+998 90 035 69 28"));
            listStudents.Add(new Student(14, "Sharafiddin", "+998 91 844 45 19"));
            listStudents.Add(new Student(15, "Muhammadali", "+998 94 933 24 35"));
            listStudents.Add(new Student(16, "Temurbek", "+998 91 319 85 26"));
            listStudents.Add(new Student(17, "Tursunboy", "+998 94 114 56 75"));
            listStudents.Add(new Student(18, "Chingizbek", "+998 93 375 25 52"));
            listStudents.Add(new Student(19, "Xusan", "+998 90 827 11 85"));
            listStudents.Add(new Student(20, "Zarina", "+998 99 452 12 24"));
            listStudents.Add(new Student(21, "Xojiakbar", "+998 94 555 44 33"));
            listStudents.Add(new Student(22, "Zikrillo", "+998 91 156 24 65"));
            listStudents.Add(new Student(23, "Mahmudjon", "+998 97 295 47 32"));

            Console.Write("Enter the ID of the student you want to search for: ");
            int getId = Convert.ToInt32(Console.ReadLine());

            foreach (Student student in listStudents)
            {
                if (getId==student.Id)
                {
                    Console.Clear();
                    Console.WriteLine($"Information about student: [Id]: {student.Id}, [Fullname]: {student.FullName}, [Phone Number]: {student.PhoneNumber}");
                }

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
}