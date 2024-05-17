namespace EmployeeWebApi.Models.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int EmployeeId);

        // Task<Employee> GetEmployeeById(int EmployeeId);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<Employee> DeleteEmployee(int employeeId);
        Task<Employee> GetEmployeeByEmail(String email);
       Task<IEnumerable<Employee>> Search(string name, Gender? gender);
    

    }
}
