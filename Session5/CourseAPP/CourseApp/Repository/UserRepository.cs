using CourseApp.Context;
using CourseApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CourseApp.Repository
{
    public class UserRepository : IUserRepository
    {
        readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddToCart(int ID)
        {
            var course= _context.Course.FirstOrDefault(x=>x.CourseID==ID);
            if (course!=null) 
            {
               // Cart cart= new Cart() { CourseId=ID,Email=em};
                return true;
            }
            else
            return false;
        }

        public bool AddToCart(string email)
        {
            throw new NotImplementedException();
        }
    }
}
