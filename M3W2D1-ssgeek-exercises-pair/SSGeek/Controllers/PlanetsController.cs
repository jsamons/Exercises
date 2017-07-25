using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSGeek.Models;
using SSGeek.DAL;

namespace SSGeek.Controllers
{
    public class PlanetsController : Controller
    {
        // GET: Planets
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult SpaceForum()
        {
            ForumPostSqlDAL dal = new ForumPostSqlDAL();
            List<ForumPost> forumPosts = dal.GetAllPosts();
            return View(forumPosts);
        }
        public ActionResult ForumPost()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForumPostResult(ForumPost post)
        {
            ForumPostSqlDAL dal = new ForumPostSqlDAL();
            bool worked = dal.SaveNewPost(post);
            if(worked == true)
            {
                TempData["ConfirmationMessage"] = "Your message has been saved!";
            }
            ForumPostSqlDAL dal2 = new ForumPostSqlDAL();
            List<ForumPost> forumPosts = dal.GetAllPosts();

            return View("SpaceForum", forumPosts);
        }

        public ActionResult TriviaQuestion()
        {
            return View("TriviaQuestion");
        }

        [HttpPost]
        public ActionResult TriviaQuestionResult(TriviaModel model)
        {
            if(model.SubmittedAnswer == "Neil Armstrong")
            {
                return RedirectToAction("TriviaQuestionCorrect", model);
            }
            else
            {
                return RedirectToAction("TriviaQuestionWrong", model);
            }
        }

        public ActionResult TriviaQuestionCorrect(TriviaModel model)
        {
            return View(model);
        }
        public ActionResult TriviaQuestionWrong(TriviaModel model)
        {
            return View(model);
        }

    }
}