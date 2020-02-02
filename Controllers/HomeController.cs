using System;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
 
    public class HomeController:Controller
    {
        
        //localhost:5000/home/index => home/index.cshtml
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewBag.Greeting = saat>12 ? "İyi Günler":"Günaydın";
            ViewBag.UserName="şafak";


            return View();
        }

        //localhost:5000/home/index => home/about.cshtml
         public IActionResult  About()
        {
            return View();
        }
    }
}