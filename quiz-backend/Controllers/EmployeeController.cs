using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quiz_backend.Controllers
{

    [Produces("application/json")]
    [Route("api/Employee")]
    public class EmployeeController : Controller
    {
        readonly EmployeeContext context;

        public EmployeeController(EmployeeContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Models.Employee> GetEmployee()
        {
            return new Models.Employee[]{
                new Models.Employee(){firstName="hello"},
            };
        }

        [HttpPost]
        public void Post([FromBody] Models.Employee employee)
        {
            context.Employee.Add(employee);
            context.SaveChanges();
            int id = employee.id;
            
        }

    }
}
