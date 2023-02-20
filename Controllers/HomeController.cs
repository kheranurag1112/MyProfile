using Microsoft.AspNetCore.Mvc;
using MyProfile.Models;
using System.Diagnostics;

namespace MyProfile.Controllers
{
    public class HomeController : Controller
    {
        
        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Skill()
        {
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult Portfolio()
        {
            return View();
        }

        public ActionResult TESTIMONIAL()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }



    }
}