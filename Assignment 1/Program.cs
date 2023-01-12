using System;

namespace Assignment_1
{
    public class Program
    {

        public  static Student CreateStudent(int?id, StudentType type, string firstName, string?lastName)
        {
            Student std = new Student();

            std.id = id == null ? 0 : id;
            std.firstName = firstName == null ? "Unknown" : firstName;
            std.lastName = lastName == null ? "" : lastName;
            std.type = type;
              
            return std;
        }

        public static void OutputStudent(Student std1)
        {
            Console.WriteLine($"Student: {std1.id} {std1.firstName} {std1.lastName} ({std1.type})");

        }




        static void Main(string[] args)
        {
            Console.WriteLine("Assignment One");
            Student student1 = CreateStudent(1,StudentType.FullTime,"Roshan","Poudel");
            OutputStudent(student1);

            Student student2 = CreateStudent(2, StudentType.PartTime, "Brock", "Lesner");
            OutputStudent(student2);

            Student student3 = CreateStudent(null, StudentType.Unknown, "Dowyne", null);
            OutputStudent(student3);

        }
    }
}

