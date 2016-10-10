using System.Collections.Generic;

namespace VirtualLaboratory.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<TeacherContact> Contact { get; set; }
    }
}
