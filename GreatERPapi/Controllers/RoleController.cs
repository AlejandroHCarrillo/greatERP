using EFDB;
using EFDB.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreatERPapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private ERPDBContext _context;
        public RoleController(ERPDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Role> Get()
        {
            return _context.Roles.ToList();
        }

        [HttpPost]
        public Role Post(Role role)
        {
            _context.Roles.Add(role); 
            _context.SaveChanges(); 

            Console.WriteLine("Role agregado con exito" );
            return role;

        }
    }
}
