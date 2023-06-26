using MediatR;
using Session3.Data.Query;
using Session3.Models;
using Session3.Services;

namespace Session3.Data.Handlers
{
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery, List<Employee>>
    {
        readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeListHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<List<Employee>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployeesListAsync();
        }
    }
}
