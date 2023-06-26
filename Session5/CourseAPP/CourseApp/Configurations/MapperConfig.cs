using AutoMapper;
using CourseApp.Context;
using CourseApp.Models.Course;
using CourseApp.Models.Student;
using CourseApp.Models.Users;

namespace CourseApp.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() { 
        CreateMap<Course,GetCoursesDto>().ReverseMap();
        CreateMap<Course,AddCourseDto>().ReverseMap();  
        CreateMap<Course,GetCourseByIdDto>().ReverseMap();  
        CreateMap<Student,GetStudentsDto>().ReverseMap();
        CreateMap<Course,UpdateCourseDto>().ReverseMap();
        CreateMap<Course, DeleteCourse>().ReverseMap();
        CreateMap<AppUser,ApiUserDto>().ReverseMap();   
        }
    }
}
