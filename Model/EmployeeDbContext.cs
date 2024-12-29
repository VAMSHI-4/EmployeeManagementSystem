using Microsoft.EntityFrameworkCore;

namespace WebAPI4.Model
{
    public class EmployeeDbContext :DbContext
    {
        public EmployeeDbContext()
        {
            
        }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> Options) :base(Options)
        {

            
        }
        public virtual DbSet<Employee> Employee{ get; set; }


    }
}
