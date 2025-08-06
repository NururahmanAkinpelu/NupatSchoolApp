using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NupatSchoolApp.Models.Entities
{
    public class Level
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Teacher> Teachers { get; set; }
    }
}
