using CourseApp.Models;

namespace CourseApp.Repository
{
    public interface IBookingRepository
    {
        void BookCourse(Booking booking);
        void CancelCourse(int bookingId);
    }

}
