using MediatR;
using Session3.Data.Command;
using Session3.Models;
using Session3.Services;

namespace Session3.Data.Handlers
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, Employee>
    {
        readonly IEmployeeRepository _employeerepository;
        public CreateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeerepository = employeeRepository;
        }
        public async Task<Employee> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            Employee emp = new Employee()
            {
                Name = request.Name,
                Email = request.Email,
                Address = request.Address,
                Phone = request.Phone
            };
            return await _employeerepository.AddEmployeeAsync(emp);
        }
    }
}
