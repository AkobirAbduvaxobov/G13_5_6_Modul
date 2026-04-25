using _5._7_AdoNet.Entities;
using _5._7_AdoNet.Repositories;

namespace _5._7_AdoNet.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public async Task<long> AddAsync(Employee employee)
        {
            return await _employeeRepository.AddEmployeeAsync(employee);
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            var enumerable = await _employeeRepository.GetAllEmployeesAsync();
            return enumerable.ToList();
        }
    }
}
