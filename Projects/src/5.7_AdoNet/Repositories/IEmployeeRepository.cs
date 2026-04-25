using _5._7_AdoNet.Entities;

namespace _5._7_AdoNet.Repositories;

public interface IEmployeeRepository
{
    Task<long> AddEmployeeAsync(Employee employee);
    Task<Employee> GetEmployeeByIdAsync(long employeeId);
    Task<IEnumerable<Employee>> GetAllEmployeesAsync();
    Task UpdateEmployeeAsync(Employee employee);
    Task DeleteEmployeeAsync(long employeeId);
    Task<IEnumerable<Employee>> GetEmployeeByDepartmentIdAsync(long departmentId);
}