using CourseAppClient.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using CourseApp.Models.Course;
using CourseApp.Context;

namespace CourseAppClient.Controllers
{
    public class CourseController : Controller
    {
        public async Task<ActionResult> GetAllCourses()
        {
            List<GetCourses> allCourses = new List<GetCourses>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7184/api/Course"))
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    allCourses = JsonConvert.DeserializeObject<List<GetCourses>>(data);

                }
                return View(allCourses);
            }
        }

        public async Task<ActionResult> GetCourseById(int id)
        {
            GetCourseById course = new GetCourseById();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7184/api/Course/" + id))
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    course = JsonConvert.DeserializeObject<GetCourseById>(data);
                }
                return View(course);
            }
        }


        [HttpGet]
        public async Task<ActionResult> AddCourses()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddCourses(AddCourseDto addCourseDto)
        {
            AddCourseDto add = new AddCourseDto();
            using (var httpClient = new HttpClient()) {
                StringContent content = new StringContent(JsonConvert.SerializeObject(addCourseDto), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:7184/api/Course", content))
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    add = JsonConvert.DeserializeObject<AddCourseDto>(data);
                }
                return View(add);
            }
        }

        //public async Task<ActionResult> UpdateCourse(Course course)
        //{
        //    using (var httpClient = new HttpClient())
        //    {
        //        // Convert the Course object to JSON
        //        string json = JsonConvert.SerializeObject(course);
        //        var content = new StringContent(json, Encoding.UTF8, "application/json");

        //        using (var response = await httpClient.PutAsync("https://localhost:7184/api/Course/" + course.Id, content))
        //        {
        //            if (response.IsSuccessStatusCode)
        //            {
        //                // Course updated successfully
        //                return RedirectToAction("Index"); // Replace "Index" with the appropriate action
        //            }
        //            else
        //            {
        //                // Handle errors
        //                string errorMessage = await response.Content.ReadAsStringAsync();
        //                ModelState.AddModelError("", errorMessage);
        //            }
        //        }
        //    }

        //    return View(course);
        //}

        [HttpPost]
        public async Task<ActionResult> UpdateCourse(int id, UpdateCourse updatePizzaDto)
        {
            using (var httpClient = new HttpClient())
            {
                string apiUrl = $"https://localhost:7222/api/Pizza/{id}";
                StringContent content = new StringContent(JsonConvert.SerializeObject(updatePizzaDto), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync(apiUrl, content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        // Update successful, handle the response if needed.
                        return RedirectToAction("GetAllCourses");
                    }
                    else
                    {
                        // Update failed, handle the response or error message.
                        string errorMessage = response.Content.ReadAsStringAsync().Result;
                        return View("Error", errorMessage);
                    }
                }
            }
        }

        public async Task<ActionResult> Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7184/api/");

                //HTTP DELETE.
                var deleteTask = client.DeleteAsync("Course/" + id.ToString());
              //  deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("GetAllCourses");
                }
            }

            return RedirectToAction("GetAllCourses");
        }
        

    }
}
