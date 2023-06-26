using MediatR;
using Session3.Data.Query;
using Session3.Models;
using Session3.Services;

namespace Session3.Data.Handlers
{
    public class GetEmployeeHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        readonly IEmployeeRepository _employeerepository;
        public GetEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeerepository = employeeRepository;
        }
        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _employeerepository.GetEmployeeByIdAsync(request.Id);
        }
    }
}
