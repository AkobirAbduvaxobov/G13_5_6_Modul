using _5._7_AdoNet.Entities;

namespace _5._7_AdoNet.Services;

public interface IEmployeeService
{
    Task<long> AddAsync(Employee employee);
    Task<List<Employee>> GetAllAsync();
}