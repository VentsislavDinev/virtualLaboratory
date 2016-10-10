using System;

namespace VirtualLaboratory.Models
{
    public class Lecture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime creationTime { get; set; }
        public LectureAnimation Animation { get; set; }
        public LectureImage LectureImage { get; set; }
        
    }
}
