using NupatSchoolApp.Interface;
using NupatSchoolApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NupatSchoolApp.Service
{
    public class TeacherServices : ITeacherService
    {
        public List<Teacher> Teachers { get; set; } = new List<Teacher>
        {
            new Teacher { Id = 1, TeacherId = "TEA/1/001", FirstName = "Ayo", LastName = "Ogunrinde", Email = "Ayo@gmail.com", Course = "Law", Level = "1" }
        };

        public void AddTeacher(string firstName, string lastName, string level, string course, string email)
        {
            var id = Teachers.Count + 1;
            string teacherId = $"TEA/{level}/{id:D3}";

            if (Teachers.Any(t => t.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Teacher Already Exists");
                return;
            }

            var newTeacher = new Teacher
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Level = level,
                Course = course,
                Email = email,
                TeacherId = teacherId
            };

            Teachers.Add(newTeacher);
            Console.WriteLine($"{newTeacher.LastName} {newTeacher.FirstName} is registered with ID {teacherId}");
        }

        public List<Teacher> GetTeachers()
        {
            if (!Teachers.Any())
            {
                Console.WriteLine("No Teachers Found");
                return new List<Teacher>();
            }

            Console.WriteLine("Teachers Found:");
            Console.WriteLine("ID\tFIRSTNAME\tLASTNAME\tEMAIL\tCOURSE");

            foreach (var teacher in Teachers)
            {
                Console.WriteLine($"{teacher.Id}\t{teacher.FirstName}\t{teacher.LastName}\t{teacher.Email}\t{teacher.Course}");
            }

            return Teachers;
        }

        public List<Teacher> GetTeachers(string parameter)
        {
            if (string.IsNullOrWhiteSpace(parameter))
            {
                Console.WriteLine("Parameter cannot be empty.");
                return new List<Teacher>();
            }

            var result = Teachers.Where(t =>
                t.FirstName.Contains(parameter, StringComparison.OrdinalIgnoreCase) ||
                t.LastName.Contains(parameter, StringComparison.OrdinalIgnoreCase) ||
                t.Email.Contains(parameter, StringComparison.OrdinalIgnoreCase) ||
                t.Level.Contains(parameter, StringComparison.OrdinalIgnoreCase) ||
                t.Course.Contains(parameter, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            if (!result.Any())
            {
                Console.WriteLine("No Teachers found with the given parameter.");
                return result;
            }

            Console.WriteLine("Teachers found:");
            Console.WriteLine("ID\tTEACHERID\tLEVEL\tFIRSTNAME\tLASTNAME\tEMAIL\tCOURSE");

            foreach (var t in result)
            {
                Console.WriteLine($"{t.Id}\t{t.TeacherId}\t{t.Level}\t{t.FirstName}\t{t.LastName}\t{t.Email}\t{t.Course}");
            }

            return result;
        }

        public Teacher GetTeacher(string teacherId)
        {
            var teacher = Teachers.FirstOrDefault(t => t.TeacherId.Equals(teacherId, StringComparison.OrdinalIgnoreCase));

            if (teacher == null)
            {
                Console.WriteLine("Teacher not found.");
                return null;
            }

            Console.WriteLine("Teacher found:");
            Console.WriteLine("ID\tTEACHERID\tLEVEL\tFIRSTNAME\tLASTNAME\tEMAIL\tCOURSE");
            Console.WriteLine($"{teacher.Id}\t{teacher.TeacherId}\t{teacher.Level}\t{teacher.FirstName}\t{teacher.LastName}\t{teacher.Email}\t{teacher.Course}");

            return teacher;
        }
    }
}
