namespace EmployeeWebApi.Models.Repositories
{
    public interface IdDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int departmentId);
    }
}
