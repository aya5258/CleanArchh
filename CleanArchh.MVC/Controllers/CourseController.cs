using CleanArch.Application.interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchh.MVC.Controllers
{
    public class CourseController : Controller
    {

        private ICourseService courseService;
        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        public IActionResult Index()

        { 
            return View(courseService.GetCourses());
        }
    }
}
