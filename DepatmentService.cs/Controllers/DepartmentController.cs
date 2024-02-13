using DepatmentService.cs.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DepatmentService.cs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        MyDbContext dbContext;

        public DepartmentController(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]

        public IEnumerable<Department> GetAll()
        {
            return dbContext.Departments.ToList();
        }
    }
}
