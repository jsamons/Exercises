using FormsWithHttpPost.DAL;
using FormsWithHttpPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormsWithHttpPost.Controllers
{
    public class HomeController : Controller
    {
        ReviewSqlDAL dal = new ReviewSqlDAL();

        // GET: Home
        public ActionResult Index()
        {
            List<Review> list = dal.GetAllReviews();
            return View(list);
        }        

        public ActionResult Review()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Review(Review review)
        {
            List<Review> list = dal.GetAllReviews();
            dal.SaveReview(review);
            return View("Index", list);
        }
    }
}