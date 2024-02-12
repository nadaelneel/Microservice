using Microsoft.EntityFrameworkCore;
namespace DepatmentService.cs.Database
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Department> Departments { get; set; }
    }
}
