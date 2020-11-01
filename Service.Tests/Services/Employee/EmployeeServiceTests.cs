using Data;
using Microsoft.EntityFrameworkCore;
using Moq;
using Service.Services.Employee;
using Xunit;

namespace Service.Tests.Services.Employee
{
    public class EmployeeServiceTests
    {
        private readonly EmployeeService _employeeService;
        private readonly DbContextOptions<DataContext> _options;
        private readonly DataContext _context;
        public EmployeeServiceTests()
        {
            _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "Database1")
                .Options;  
            _context = new DataContext(_options);
            _employeeService  = new EmployeeService(_context);
        }
        
        [Fact]
        public void GetEmployeeById_ShouldReturnRecord()
        {
            //Arrange

            // Insert seed data into the database using one instance of the context
             var context = new DataContext(_options);
            context.Employees.Add(new Data.Entities.Employee()
            {
                Id = 1,
                Name = "test"
            });
            context.SaveChanges();
            //Act
            var emp = _employeeService.GetEmployeeById(1);
            
            //Assert
            Assert.Equal("test",emp.Name);
        }
        
        [Fact]
        public void GetEmployeeById_ShouldReturnNull()
        {
            //Arrange
            
            //Act
            var emp = _employeeService.GetEmployeeById(1);
            
            //Assert
            Assert.Null(emp);
        }
    }
}