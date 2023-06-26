using CourseApp.Context;
using CourseApp.Models.Course;
using Microsoft.EntityFrameworkCore;

namespace CourseApp.Repository
{
    public class CourseRepository : ICourseRepository
    {
        readonly CourseDbContext _context;   
        public CourseRepository(CourseDbContext context)
        {
            _context = context;
        }

        public  async Task<List<Course>> GetCourses()
        {
            return await _context.Courses.ToListAsync();

        }
        public void AddCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public async Task<Course> GetCourseById(int id)
        {
           Course course= await _context.Courses.Include(q=>q.Students).FirstOrDefaultAsync(a => a.Id == id);
            return course;
        }



        //public void UpdateCourse (Course course)
        //{
        //    var existingCourse = _context.Courses.FirstOrDefault(q => q.Id == course.Id);
        //    if (existingCourse != null)
        //    {
        //        existingCourse.Name = course.Name;
        //        existingCourse.Price = course.Price;
        //        existingCourse.Description = course.Description;

        //    }
        //}

        public async Task UpdateCourse(Course course)
        {
            var existingCourse = await _context.Courses.FindAsync(course.Id);
            if (existingCourse != null)
            {
                existingCourse.Name = course.Name;
                existingCourse.Price = course.Price;
                existingCourse.Description = course.Description;

                await _context.SaveChangesAsync();
            }
        }

       

        public async Task DeleteCourse(int id)
        {
            var existingCourse = await _context.Courses.FindAsync(id)
;
            if (existingCourse != null)
            {
                _context.Courses.Remove(existingCourse);
                await _context.SaveChangesAsync();
            }
        }
    }
}
