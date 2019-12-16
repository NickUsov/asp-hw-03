using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int weapon)
        {
            Warrior warrior = null;
            if (weapon == 1)
            {
                warrior = new Warrior(new Sword());
            }
            else
            {
                warrior = new Warrior(new Bazuka());
            }
            ViewBag.shoot = warrior.Shoot(); 
            return View("Shoot");
        }
    }
}