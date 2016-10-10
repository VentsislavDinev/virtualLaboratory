using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualLaboratory.Models
{
    public class VirtualLaboratoryDbContext : DbContext
    {
        public VirtualLaboratoryDbContext()
            : base("DefaultConnection")
        {
            
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SocialContact> SocialContacts { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherContact> TeacherContact { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<ForumPostVote> ForumPostVotes { get; set; }
        public DbSet<ForumPost> ForumPosts { get; set; }
        public DbSet<ForumPostAnswer> ForumPostAnswers { get; set; }
    }
}
