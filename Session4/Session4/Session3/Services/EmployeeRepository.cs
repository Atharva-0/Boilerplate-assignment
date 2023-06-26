using Microsoft.EntityFrameworkCore;
using Session3.Data;
using Session3.Models;

namespace Session3.Services
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private readonly DataContext _dbcontext;

        public EmployeeRepository(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            var result =_dbcontext.Employees.Add(employee);
            await _dbcontext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteEmployeeAsync(int id)
        {
            var filteredData=_dbcontext.Employees.Where(x=>x.Id == id).FirstOrDefault();
            _dbcontext.Employees.Remove(filteredData);
            return await _dbcontext.SaveChangesAsync();
        }

       
        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            var filterData = await _dbcontext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            return filterData;
        }

        public async Task<List<Employee>> GetEmployeeListAsync()
        {
            var filteredData = await _dbcontext.Employees.ToListAsync();
            return filteredData;
        }

        public Task<List<Employee>> GetEmployeesListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateEmployeeAsync(Employee employee)
        {
            _dbcontext.Employees.Update(employee);
            return await _dbcontext.SaveChangesAsync();
        }

    }
}
