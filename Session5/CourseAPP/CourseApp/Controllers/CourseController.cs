using AutoMapper;
using CourseApp.Context;
using CourseApp.Models.Course;
using CourseApp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        readonly ICourseRepository _courseRepository;
        readonly IMapper _mapper;
        public CourseController(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetCourse()
        {
            List<Course> allcourses = await _courseRepository.GetCourses();
            var records = _mapper.Map<List<GetCoursesDto>>(allcourses);
            return Ok(records);
        }

        [HttpPost]
        public async Task<ActionResult> AddCourse(AddCourseDto addCourseDto)
        {

            var addRecords = _mapper.Map<Course>(addCourseDto);
                _courseRepository.AddCourse(addRecords);
            return CreatedAtAction("GetCourseById", new {id = addRecords.Id},addRecords);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetCourseByIdDto>>GetCourseById(int id)
        {
            Course course = await _courseRepository.GetCourseById(id);
            var courseDto = _mapper.Map<GetCourseByIdDto>(course);
            return Ok(courseDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCourse(int id, UpdateCourseDto updateCourseDto)
        {
            var existingCourse = await _courseRepository.GetCourseById(id)
;
            if (existingCourse == null)
            {
                return NotFound();
            }

            existingCourse.Name = updateCourseDto.Name;
            existingCourse.Price = updateCourseDto.Price;
            existingCourse.Description = updateCourseDto.Description;

            await _courseRepository.UpdateCourse(existingCourse);

            return NoContent(); 
        }




        //[HttpDelete("{id}")]
        //public async Task< ActionResult<GetCourseByIdDto> DeleteCourse(int id)
        //{
        //    var courseToDelete =  _courseRepository.GetCourseById(id);
        //    if (courseToDelete == null)
        //    {
        //        return NotFound();
        //    }

        //    // Delete the course from the repository
        //    _courseRepository.DeleteCourse(courseToDelete);

        //    return NoContent();
        //}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var existingCourse = await _courseRepository.GetCourseById(id)
;
            if (existingCourse == null)
            {
                return NotFound();
            }

            await _courseRepository.DeleteCourse(id)
;

            return NoContent();
        }



    }
}
