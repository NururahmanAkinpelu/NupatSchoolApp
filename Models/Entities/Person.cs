using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NupatSchoolApp.Models.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        // Navigation properties
        //public virtual ICollection<Level> Levels { get; set; } = new List<Level>();
    }

    public enum Gender
    {
        Male = 1,
        Female,
        Shemale,
    }
}
