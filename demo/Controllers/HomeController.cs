using demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Index()
        {
            List<student> std = new List<student>
            {
                new student
                {
                    city = "surat",
                    number = 1,
                    name = "nanu"
                },
                new student
                {
                    city = "bhavnagar",
                    number = 2,
                    name = "gopi"
                },
                
            };
            //ViewData["Message"] = std;
             return View(std);
            
        }
        public ActionResult create()
        {
            return View();
        }
        
    }
}