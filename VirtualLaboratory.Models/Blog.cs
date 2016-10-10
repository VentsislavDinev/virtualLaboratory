namespace VirtualLaboratory.Models
{
    using System;
    using System.Collections.Generic;

    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public UserProfile UserNamer { get; set; }
        public IEnumerable<BlogComment> BlogComment { get; set; }
        public IEnumerable<BlogTag> BlogTag { get; set; }
    }
}
