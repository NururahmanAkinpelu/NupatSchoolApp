using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NupatSchoolApp.Models.Entities
{
    public class Student : Person
    {
        public string Level { get; set; }
        public string StudentId { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
