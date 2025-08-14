using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NupatSchoolApp.Models.Entities
{
    public class Teacher : Person
    {
        public string TeacherId { get; set; }
        public string Course { get; set; }
        public List<Level> Levels { get; set; }

    }
}
