using MediatR;
using Session3.Data.Command;
using Session3.Services;

namespace Session3.Data.Handlers
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, int>
    {
        readonly IEmployeeRepository _employeeRepository;

        public UpdateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        async Task<int> IRequestHandler<UpdateEmployeeCommand, int>.Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeByIdAsync(request.Id);
            if (employee == null) { return default; }
            employee.Name = request.Name;
            employee.Email = request.Email;
            employee.Phone = request.Phone;
            employee.Address = request.Address;
            return await _employeeRepository.UpdateEmployeeAsync(employee);
        }
    }
}
