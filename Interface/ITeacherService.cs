using NupatSchoolApp.Models.Entities;

namespace NupatSchoolApp.Interface
{
    public interface ITeacherService
    {
        void AddTeacher(string firstName, string lastName, string course, string email);
        List<Teacher> GetTeachers();
        List<Teacher> GetTeachers(string parameter);
        Teacher GetTeacher(string teacherId);
    }
}
