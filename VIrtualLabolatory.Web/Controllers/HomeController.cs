namespace Sofia.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using VIrtualLabolatory.ViewModels.Blog;
    using VIrtualLabolatory.ViewModels.Contact;
    using VIrtualLabolatory.ViewModels.Forum;
    using VirtualLaboratory.Models;

    public class HomeController : Controller
    {
        SofiaDb db = new SofiaDb();


        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListLastForumPost()
        {
            var latestForumPosts = db.ForumPosts
                .OrderByDescending(x => x.CreationTime)
                .Take(10)
                .Select(x => new ForumPostViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    CreationTime = x.CreationTime,
                    Username = x.Author.UserName,
                    Rating =
                        db.ForumPostVotes.Count(y => y.Post.Id == x.Id && y.IsUpVote) -
                        db.ForumPostVotes.Count(y => y.Post.Id == x.Id && !y.IsUpVote)
                });            

            return PartialView(latestForumPosts);
        }

        public ActionResult MenuForAllLecture()
        {
            return PartialView();
        }

        public ActionResult ListAllBlogPost()
        {
            var getLastBlogPost = this.db.Blogs.OrderByDescending(x => x.CreationTime)
                .Take(10)
                .Select(x=> new BlogViewModel
                {
                    Id = x.Id,
                    CreationTime = x.CreationTime,
                    Description = x.Description,
                    Name = x.Name,
                    UserName = x.UserNamer.UserName,
                });    
            return PartialView(getLastBlogPost);
        }

        public ActionResult Contact(int id)
        {

            var getContact = this.db.Contacts.OrderByDescending(cnn => cnn.CreationTime)
                .Select(x => new ContactViewModel
                {
                    Email = x.Email,
                    Phone = x.Phone,
                    Place = x.Place,
                    CreationTime = x.CreationTime
                }).SingleOrDefault();
            getContact.SocialContact = db.SocialContacts
                .Where(x => x.contacts.Id == id)
                .Select(x => new ContactSocialViewModel {
                    SocialNetwork = x.SocialNetwork,
                    SocialNetworkImage = x.SocialNetworkImage,
                    SocialNetworkLink = x.SocialNetworkLink,
                  });


            return PartialView(getContact);
        }

        public ActionResult FeedBack()
        {
            return PartialView();
        }

        public ActionResult PostFeedBack(FeedBack feedBack)
        {
            var newFeedBack = new FeedBack
            {
                 Name  = feedBack.Name,
                 Description  = feedBack.Description,
                 Email = feedBack.Email,
                 Phone = feedBack.Phone,
            };
            db.FeedBacks.Add(newFeedBack);
            this.db.SaveChanges();

            return Redirect("/");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
