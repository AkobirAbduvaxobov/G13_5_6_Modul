using _5._7_AdoNet.Entities;
using _5._7_AdoNet.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _5._7_AdoNet.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController()
        {
            _employeeService = new EmployeeService();
        }

        [HttpPost]
        public async Task<long> AddEmployee(Employee employee)
        {
            var employeeId = await _employeeService.AddAsync(employee);
            return employeeId;
        }

        [HttpGet]
        public async Task<List<Employee>> GetAllEmployees()
        {
            var employees = await _employeeService.GetAllAsync();
            return employees;
        }
    }
}
