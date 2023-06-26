using MediatR;
using Session3.Models;

namespace Session3.Data.Query
{
    public class GetEmployeeByIdQuery : IRequest<Employee>
    {
        public int Id { get; set; }
    }
}
