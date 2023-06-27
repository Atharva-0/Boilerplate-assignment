using CourseApp.Models;
using CourseApp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class AdminController : Controller
    {
        readonly ICourseRepository _courseRepository;


        //readonly IProductServices _productServices;
        public AdminController(ICourseRepository courseServices)
        {
            _courseRepository = courseServices;
        }
        public IActionResult Index()
        {
            List<Course> allCourse = _courseRepository.GetAllCourse();
            return View(allCourse);
        }

        [HttpGet]
        public ActionResult AddCourse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCourse(Course course)
        {
            _courseRepository.AddCourse(course);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditCourse(int id)
        {
            return View(_courseRepository.GetCourseByID(id));
        }

        [HttpPost]
        public ActionResult EditCourse(Course course)
        {
            _courseRepository.Update(course);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DelCourse(int Id)
        {

            _courseRepository.DelCourse(Id)
;
            return RedirectToAction("Index");
        }

    }

}
