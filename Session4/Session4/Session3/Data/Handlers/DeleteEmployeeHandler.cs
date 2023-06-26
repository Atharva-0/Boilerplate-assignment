using MediatR;
using Session3.Data.Command;
using Session3.Services;

namespace Session3.Data.Handlers
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, int>
    {
        readonly IEmployeeRepository _employeeRepository;
        public DeleteEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<int> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeByIdAsync(request.Id);
            if (employee == null) { return default; }
            return await _employeeRepository.DeleteEmployeeAsync(request.Id);
        }
    }
}
