using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIrtualLabolatory.ViewModels.Forum
{
    public class ForumPostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public DateTime CreationTime { get; set; }
        public int Rating { get; set; }
    }
}