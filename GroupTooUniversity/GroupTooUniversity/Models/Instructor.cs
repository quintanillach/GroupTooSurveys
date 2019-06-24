using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupTooUniversity.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Email { get; set; }
        public ICollection<Survey> Surveys { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}
