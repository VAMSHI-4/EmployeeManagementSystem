using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI4.Model;

namespace WebAPI4.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public EmployeeController(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        [HttpGet]

        public IActionResult Get()
        {


            var result = _employeeDbContext.Employee.ToList();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult POSTEmployee(Employee employee)
        {
            _employeeDbContext.Employee.Add(employee);
            _employeeDbContext.SaveChanges();
            return Ok("Record Created");
        }
        [HttpPut]
        public IActionResult PutEmployee(Employee employee)
        {
            _employeeDbContext.Entry(employee).State = EntityState.Modified;
            _employeeDbContext.SaveChanges();
            return Ok("Record Updated");
        }
        [HttpDelete]
        public IActionResult DeleteEmployee(int id)
        {
            var result = _employeeDbContext.Employee.Find(id);
            _employeeDbContext.Employee.Remove(result);
            _employeeDbContext.SaveChanges();
            return Ok("Record Deleted");
        }
    }
}
