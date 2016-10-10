namespace VirtualLaboratory.Models
{
    public class BlogComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public UserProfile UserName { get; set; }
    }
}