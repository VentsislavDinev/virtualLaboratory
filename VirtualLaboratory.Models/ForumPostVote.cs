using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualLaboratory.Models
{
    public class ForumPostVote
    {
        public int Id { get; set; }
        public UserProfile User { get; set; }
        public ForumPost Post { get; set; }
        public bool IsUpVote { get; set; }
    }
}
