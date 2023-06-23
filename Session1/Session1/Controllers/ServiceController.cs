using Session1.Interface;
using Session1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Session1.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServices services;

        public ServiceController(IServices services)
        {
            this.services = services;
        }

        public IActionResult Index()
        {
            try
            {
                string myValue = services.GetValue("greet");
               
              return View("Index",myValue);
            }
            catch (InvalidOperationException ex)
            {
                
                return RedirectToAction("Error", "Index");
            }
        }
    }
}
