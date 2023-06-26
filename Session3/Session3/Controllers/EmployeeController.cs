using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Session3.Data;
using Session3.Data.Command;
using Session3.Data.Query;
using Session3.Models;

namespace Session3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        // [Route("/abc")]
        public async Task<IActionResult> EmployeeList()
        {
            var employeeList = await _mediator.Send(new GetEmployeeListQuery());
            return Ok(employeeList);
        }

        [HttpGet("{id}")]
        public async Task<Employee> EmployeeById(int id)
        {
            var employee = await _mediator.Send(new GetEmployeeByIdQuery() { Id = id });
            return employee;
        }
        [HttpPost]
        public async Task<Employee> AddEmployee(Employee employee) {
            var emp = await _mediator.Send(new CreateEmployeeCommand(employee.Name, employee.Address,
                employee.Email, employee.Phone));
            return emp;
        }

        [HttpPut]
        public async Task<int> UpdateEmployee(Employee employee)
        {
            var employeeReturn = await _mediator.Send(new UpdateEmployeeCommand(employee.Id, employee.Name, employee.Address,
                                                                      employee.Email, employee.Phone));
            return employeeReturn;
        }
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id) 
        {
            return await _mediator.Send(new DeleteEmployeeCommand() { Id = id });
        }
    }
}
