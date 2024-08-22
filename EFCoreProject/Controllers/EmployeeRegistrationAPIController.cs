using EFCoreProject.Data;
using JobPortalApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobPortalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeRegistrationAPIController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeRegistrationAPIController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<Employee>> GetAllEmployee()
        {
            // Getting all columns from table
            var result = await (from Employee in _appDbContext.Employees select Employee).ToListAsync();

            // Getting selected columns from table (other Class props values are null is this case)
            //var result = await (from Employee in _appDbContext.Employees select new Employee { Id = Employee.Id, Name = Employee.Name}).ToListAsync();

            // Getting selected columns from table (Other class props are not shown in object)
            //var result = await (from Employee in _appDbContext.Employees select new { Id = Employee.Id, Name = Employee.Name }).ToListAsync();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployeeByID([FromRoute] int id)
        {
            var result = await _appDbContext.Employees.FindAsync(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            await _appDbContext.Employees.AddAsync(employee);
            await _appDbContext.SaveChangesAsync();
            return Ok(employee);
        }
    }
}
