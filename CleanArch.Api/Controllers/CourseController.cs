using CleanArch.Application.interfaces;
using CleanArch.Application.Services;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {

        private readonly ICourseService courseService;


        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CourseViewModel courseViewModel)
        {
            courseService.Create(courseViewModel);

            return Ok(courseViewModel);
        }
    }
}