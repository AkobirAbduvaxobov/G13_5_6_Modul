using _5._7_AdoNet.Entities;
using Microsoft.Data.SqlClient;
using System.Data;


namespace _5._7_AdoNet.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly string _connectionString;

        public EmployeeRepository()
        {
            _connectionString = "Data Source=localhost\\SQLDEV;User ID=sa;Password=1;Initial Catalog=AdoNet;TrustServerCertificate=True;";
        }

        public async Task<long> AddEmployeeAsync(Employee employee)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand("AddEmployee", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
            cmd.Parameters.AddWithValue("@LastName", employee.LastName);
            cmd.Parameters.AddWithValue("@DepartmentId", employee.DepartmentId);
            cmd.Parameters.AddWithValue("@Position", employee.Position);
            cmd.Parameters.AddWithValue("@HireDate", employee.HireDate);
            cmd.Parameters.AddWithValue("@Salary", employee.Salary);

            await conn.OpenAsync();
            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            var employeeId = await reader.ReadAsync() ? reader.GetInt64(0) : 0;
            return employeeId;
        }

        public Task DeleteEmployeeAsync(long employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            var list = new List<Employee>();

            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand("GetAllEmployees", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            await conn.OpenAsync();

            using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                list.Add(new Employee
                {
                    EmployeeId = Convert.ToInt64(reader["EmployeeId"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Position = reader["Position"].ToString(),
                    Salary = Convert.ToDecimal(reader["Salary"]),
                    HireDate = Convert.ToDateTime(reader["HireDate"]),
                    DepartmentId = Convert.ToInt64(reader["DepartmentId"])
                });
            }

            return list;
        }

        public Task<IEnumerable<Employee>> GetEmployeeByDepartmentIdAsync(long departmentId)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeByIdAsync(long employeeId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeeAsync(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
