using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIrtualLabolatory.ViewModels.Forum
{
    public class ForumPostAnswerViewModel
    {
        public string Content { get; set; }
        public string Username { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime EditTime { get; set; }
    }
}