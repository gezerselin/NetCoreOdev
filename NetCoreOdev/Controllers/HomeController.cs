using NetCoreOdev.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NetCoreOdev.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<Course> courses = new List<Course>();
            courses.Add(new Course { CourseName = "Tiyatro kursu", Price = 300 });
            courses.Add(new Course { CourseName = "Bateri kursu", Price = 500 });
            courses.Add(new Course { CourseName = "Gitar kursu", Price = 400 });

            return View(courses);
        }
        
        
        public IActionResult Kayit()
        {

            return View();
        }

  
        [HttpPost]
        public IActionResult Kayit(UserResponse userResponse)
        {
            if (ModelState.IsValid)
            {
                
                Register.Add(userResponse);
                return View("Tebrikler", userResponse);
                
            }

            return View();
        }

        public IActionResult TiyatroKayitListe()
        {
            return View(Register.theaterCourse);
        }
        public IActionResult BateriKayitListe()
        {
            return View(Register.drumCourse);
        }
        public IActionResult GitarKayitListe()
        {
            return View(Register.guitarCourse);
        }

    }
}
