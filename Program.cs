using NupatSchoolApp.Interface;
using NupatSchoolApp.Service;

public class Program
{
    
    static void Main(string[] args)
    {
        var sv = new StudentService();
        var t = new TeacherServices();
        Console.WriteLine("Welcome to the School App");
        Console.WriteLine("Enter the course the teacher is teaching");
        string course = Console.ReadLine();
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
        t.AddTeacher(FirstName, LastName, course, email);
/*        Console.WriteLine("Enter a parameter to search for students (e.g., age, name, etc.)");
        var paramter = Console.ReadLine();
        sv.GetStudents(paramter);*/
        /*        Console.WriteLine("Enter a student ID to retrieve student details");
                var studentId = Console.ReadLine();
                var student = sv.GetStudent(studentId);*/
    }
}

