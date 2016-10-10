using System;
using System.Collections.Generic;

namespace VIrtualLabolatory.ViewModels.Contact
{
    public class ContactViewModel
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Place { get; set; }

        public IEnumerable<ContactSocialViewModel> SocialContact { get; set; }
    }
}