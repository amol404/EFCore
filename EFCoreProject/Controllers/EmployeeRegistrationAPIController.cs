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
            var result = await (from Employee in _appDbContext.Employees select Employee).ToListAsync();

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
