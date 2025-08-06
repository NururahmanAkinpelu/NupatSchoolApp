using NupatSchoolApp.Interface;
using NupatSchoolApp.Service;

public class Program
{
    
    static void Main(string[] args)
    {
        var sv = new StudentService();
        /*Console.WriteLine("Welcome to the School App");
        Console.WriteLine("Enter the level of the student (e.g., 1, 2, 3)");
        string level = Console.ReadLine();
        Console.WriteLine("Enter your Name");
        string FirstName = Console.ReadLine();
        Console.WriteLine("Enter your LastName");
        string LastName = Console.ReadLine();
        Console.WriteLine("Enter your age");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your email");
        string email = Console.ReadLine();
        Console.WriteLine("Enter your address");
        string address = Console.ReadLine();
        sv.AddStudent(FirstName, level, LastName, email, age, address);*/
        /*        Console.WriteLine("Enter a parameter to search for students (e.g., age, name, etc.)");
                var paramter = Console.ReadLine();
                sv.GetStudents(paramter);*/
        Console.WriteLine("Enter a student ID to retrieve student details");
        var studentId = Console.ReadLine();
        var student = sv.GetStudent(studentId);
    }
}

