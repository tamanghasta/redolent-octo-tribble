using responsive_tutorials.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace responsive_tutorials.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult News()
        {
            var news1 = new NewsModel { NewsId = 1, Summary = "This is a summary for the most famous ", Title = "Title One" };
            var news2 = new NewsModel { NewsId = 2, Summary = "I am the number two of this clan", Title = "Title Two" };
            var news3 = new NewsModel { NewsId = 3, Summary = "Quick brown fox jump onto a lazy dog", Title = "Title Three" };
            var news4 = new NewsModel { NewsId = 4, Summary = "Peter bought a butter but the butter was very bitter, to make it better he put a sugar.", Title = "Title Four" };

            List<NewsModel> NewsList = new List<NewsModel>();
            NewsList.Add(news1);
            NewsList.Add(news2);
            NewsList.Add(news3);
            NewsList.Add(news4);

            return View(NewsList);
        }
    }
}