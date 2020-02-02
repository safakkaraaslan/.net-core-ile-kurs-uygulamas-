using System.Linq;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController:Controller
    {


        //action method
        //localhost:5000/course/index => course/index.cshtml
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        //localhost:5000/course/apply 
        public IActionResult Apply()
        {
         
          return View();
        }
        //localhost:5000/course/apply method:POST
        // Name=value&Email=value&Phone=value&Confirm=value
         [HttpPost]
         public IActionResult Apply(Student student)
        {
           //model binding
          //database kayıt

          if(ModelState.IsValid)
          {
              Repository.AddStudent(student);
              return View("Thanks", student);
          }
          else // eger bir validation hatası varsa
          {
              return View(student);
          }
          
          
        }

         public IActionResult Details()
        {
            //name:"Core Mvc Kursu"
            //description: "güzel bir kurs"
            //ispublished: true

            var course = new Course();
            course.Name = "Core Mvc Kurse";
            course.Description="güzel bir kurs";
            course.İsPublished= true;

            return View(course);
        }
          //localhost:5000/course/list => course/list.cshtml
         public IActionResult List()
        {
            var students = Repository.Students.Where(i=>i.Confirm==true);
            return View(students);
        }
        
    }
}