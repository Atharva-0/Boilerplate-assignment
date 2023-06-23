using CourseApp.Models;
using CourseApp.Repository;
using CourseApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class UserController : Controller

    {
        readonly ICourseService _courseService;
        public UserController(ICourseService courseServices)
        {
            _courseService = courseServices;
        }
        public IActionResult Index()
        {
            List<Course> allCourse = _courseService.GetAllCourse();
            return View(allCourse);
        }

        public IActionResult AddToCart(string email)
        {
            if(ModelState.IsValid)
            {

            }
            return View();  
        }

    }
}
