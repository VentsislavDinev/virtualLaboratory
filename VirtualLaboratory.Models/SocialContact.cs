namespace VirtualLaboratory.Models
{
    public class SocialContact
    {
        public int Id { get; set; }
        public Contact contacts { get; set; }
        public string SocialNetwork { get; set;}

        public string SocialNetworkImage { get; set; }

        public string SocialNetworkLink { get; set; }
    }
}