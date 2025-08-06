using NupatSchoolApp.Interface;
using NupatSchoolApp.Models.Entities;

namespace NupatSchoolApp.Service
{
    public class StudentService : IStudentService
    {
        public List<Student> Students { get; set; } = new List<Student>
        {
            new Student { Id = 1, StudentId = $"STU/1/001", FirstName = "Ayo", LastName = "Adekunle", Email = "ay@gmail.com", Age = 56, Address = "Ikoyi", Level = "1"},
            new Student { Id = 2, StudentId = $"STU/1/002", FirstName = "Ade", LastName = "Adekunle", Email = "ade@gmail.com", Age = 6, Address = "Lekki", Level = "1"},
            new Student { Id = 3, StudentId = $"STU/2/003", FirstName = "Jola", LastName = "Balogun", Email = "joola@gmail.com", Age = 36, Address = "Ajah", Level = "2"},
            new Student { Id = 4, StudentId = $"STU/3/004", FirstName = "Ayo", LastName = "Adelek", Email = "ayo@gmail.com", Age = 26, Address = "Agungi", Level = "3"}
        };

        public void AddStudent(string firstName, string level, string lastName, string email, int age, string address)
        {
            var id = Students.Count + 1;
            string studentId = $"STU/{level}/{id:D3}"; // Format student ID as STU001, STU002, etc.

            var newStudent = new Student

            {
                Id = id, FirstName = firstName, LastName = lastName, Email = email, Age = age, Address = address, Level = level, StudentId = studentId
            };
            if (Students.Contains(newStudent))
            {
                Console.WriteLine("Student already exists");
            };

            Students.Add(newStudent);

            Console.WriteLine($"{newStudent.LastName} {newStudent.FirstName} is registered");
        }

        public List<Student> GetStudents()
        {
            if (Students.Count == 0)
            {
                Console.WriteLine("No students found");
                return new List<Student>();
            }
            Console.WriteLine("Students found");

            foreach (var student in Students)
            {
                Console.WriteLine("ID\tFIRSTNAME\tLASTNAME\tEMAIL\tAGE\tADDRESS");
                Console.WriteLine($"{student.Id}\t{student.FirstName}\t{student.LastName}\t{student.Email}\t{student.Age}\t{student.Address}");
            }
            return Students;
        }

        public List<Student> GetStudents(string parameter)
        {
            if (string.IsNullOrEmpty(parameter))
            {
                Console.WriteLine("Parameter cannot be null or empty");
                return new List<Student>();
            }
            var c = Students.Where(student => student.FirstName.Contains(parameter, StringComparison.OrdinalIgnoreCase) ||
                                  student.LastName.Contains(parameter, StringComparison.OrdinalIgnoreCase) ||
                                  student.Email.Contains(parameter, StringComparison.OrdinalIgnoreCase) ||
                                  student.Level.Contains(parameter, StringComparison.OrdinalIgnoreCase) ||
                                  //student.Age.ToString().Contains(parameter) ||
                                  student.Address.Contains(parameter, StringComparison.OrdinalIgnoreCase)).ToList();
            
            if (c.Count == 0)
            {
                Console.WriteLine("No students found with the given parameter");
                return new List<Student>();
            }
            Console.WriteLine("Students found with the given parameter");
            foreach (var student in c)
            {
                Console.WriteLine("ID\tFIRSTNAME\tLASTNAME\tEMAIL\tAGE\tADDRESS");
                Console.WriteLine($"{student.Id}\t{student.FirstName}\t{student.LastName}\t{student.Email}\t{student.Age}\t{student.Address}");
            }
            return c;
        }

        public Student GetStudent(string studentId)
        {
            var student = Students.FirstOrDefault(s => s.StudentId.Equals(studentId, StringComparison.OrdinalIgnoreCase));
            if (student == null)
            {
                Console.WriteLine("Student not found");
                return null;
            }
            Console.WriteLine("Student found");
            Console.WriteLine("ID\tSTUDENTID\tLEVEL\tFIRSTNAME\tLASTNAME\tEMAIL\tAGE\tADDRESS");
            Console.WriteLine($"{student.Id}\t{student.StudentId}\t{student.Level}\t{student.FirstName}\t{student.LastName}\t{student.Email}\t{student.Age}\t{student.Address}");
            return student;
        }
    }
}
