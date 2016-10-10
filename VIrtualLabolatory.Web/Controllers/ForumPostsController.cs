namespace VIrtualLabolatory.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using VIrtualLabolatory.ViewModels.Forum;
    using VIrtualLabolatory.Web.Filters;
    using VirtualLaboratory.Models;
    using WebMatrix.WebData;


    public class ForumPostsController : Controller
    {
        SofiaDb db = new SofiaDb();

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [InitializeSimpleMembership]
        public ActionResult DoCreate(ForumPost forumPost)
        {
            var user = db.UserProfiles.FirstOrDefault(x => x.UserId == WebSecurity.CurrentUserId);
            var post = new ForumPost
                {
                    Content = Server.HtmlDecode(forumPost.Content),
                    CreationTime = DateTime.Now,
                    Title = forumPost.Title,
                    Author = user,
                };
            db.ForumPosts.Add(post);
            db.SaveChanges();

            return Redirect("/");
        }

        public ActionResult ViewPost(int postId)
        {
            if (!db.ForumPosts.Any(x => x.Id == postId))
            {
                return Redirect("/");
            }

            var post = db.ForumPosts.Where(x => x.Id == postId)
                .Select(x => new FullForumPostViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Content = x.Content,
                    CreationTime = x.CreationTime,
                    Username = x.Author.UserName,
                }).SingleOrDefault();

            post.Answers = db.ForumPostAnswers.Where(x => x.ForumPost.Id == postId)
                    .Select(y => new ForumPostAnswerViewModel
                    {
                        Content = y.Content,
                        CreationTime = y.CreationTime,
                        EditTime = y.EditTime,
                        Username = y.Author.UserName,
                    });

            return View(post); // FullForumPostViewModel
        }

        [Authorize]
        [HttpPost]
        [InitializeSimpleMembership]
        public ActionResult DoAnswer(int forumPostId, string content)
        {
            var user = db.UserProfiles.FirstOrDefault(x => x.UserId == WebSecurity.CurrentUserId);
            var forumPost = db.ForumPosts.FirstOrDefault(x => x.Id == forumPostId);
            
            db.ForumPostAnswers.Add(
                new ForumPostAnswer()
                {
                    Author = user,
                    Content = Server.HtmlDecode(content),
                    CreationTime = DateTime.Now,
                    EditTime = DateTime.Now,
                    ForumPost = forumPost,
                });
            db.SaveChanges();

            return Redirect("/Questions/" + forumPostId);
        }

        [Authorize]
        [InitializeSimpleMembership]
        public ActionResult VoteUp(int id)
        {
            if (db.ForumPostVotes.Any(x => x.Post.Id == id && x.User.UserId == WebSecurity.CurrentUserId))
            {
                var currentEntry = db.ForumPostVotes.SingleOrDefault(x => x.Post.Id == id && x.User.UserId == WebSecurity.CurrentUserId);
                currentEntry.IsUpVote = true;
                db.SaveChanges();
            }
            else
            {
                var user = db.UserProfiles.FirstOrDefault(x => x.UserId == WebSecurity.CurrentUserId);
                var forumPost = db.ForumPosts.FirstOrDefault(x => x.Id == id);
                db.ForumPostVotes.Add(new ForumPostVote()
                {
                    Post = forumPost,
                    User = user,
                    IsUpVote = true,
                });
                db.SaveChanges();
            }
            int rating = db.ForumPostVotes.Count(y => y.Post.Id == id && y.IsUpVote) -
                        db.ForumPostVotes.Count(y => y.Post.Id == id && !y.IsUpVote);

            return Content(rating.ToString());
        }

        [Authorize]
        [InitializeSimpleMembership]
        public ActionResult VoteDown(int id)
        {
            if (db.ForumPostVotes.Any(x => x.Post.Id == id && x.User.UserId == WebSecurity.CurrentUserId))
            {
                var currentEntry = db.ForumPostVotes.SingleOrDefault(x => x.Post.Id == id && x.User.UserId == WebSecurity.CurrentUserId);
                if (currentEntry.IsUpVote == false)
                {
                    db.ForumPostVotes.Remove(currentEntry);
                }
                else
                {
                    currentEntry.IsUpVote = false;
                }
                db.SaveChanges();
            }
            else
            {
                var user = db.UserProfiles.FirstOrDefault(x => x.UserId == WebSecurity.CurrentUserId);
                var forumPost = db.ForumPosts.FirstOrDefault(x => x.Id == id);
                db.ForumPostVotes.Add(new ForumPostVote()
                {
                    Post = forumPost,
                    User = user,
                    IsUpVote = false,
                });
                db.SaveChanges();
            }
            int rating = db.ForumPostVotes.Count(y => y.Post.Id == id && y.IsUpVote) -
                        db.ForumPostVotes.Count(y => y.Post.Id == id && !y.IsUpVote);

            return Content(rating.ToString());
        }
    }
}
