using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualLaboratory.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        
        public string Place { get; set; }

        public IEnumerable<SocialContact> socialContact { get; set; }
    }
}
