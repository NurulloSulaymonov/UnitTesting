using Data;

namespace Service.Services.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DataContext _context;

        public EmployeeService(DataContext context)
        {
            _context = context;
        }

        public Data.Entities.Employee GetEmployeeById(int id)
        {
            var emp =  _context.Employees.Find(id);
            return emp;
        }
    }
}