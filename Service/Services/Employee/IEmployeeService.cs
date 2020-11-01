namespace Service.Services.Employee
{
    public interface IEmployeeService
    {
        Data.Entities.Employee GetEmployeeById(int id);
    }
}