using NupatSchoolApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NupatSchoolApp.Interface
{
    public interface IStudentService
    {
        void AddStudent(string fistName, string lastName, string level, string email, int age, string address);
        List<Student> GetStudents();
        List<Student> GetStudents(string parameter);
        Student GetStudent(string studentId);


    }
}
