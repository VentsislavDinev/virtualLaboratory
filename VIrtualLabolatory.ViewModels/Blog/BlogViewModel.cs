using System;

namespace VIrtualLabolatory.ViewModels.Blog
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public string UserName { get; set; }
    }
}