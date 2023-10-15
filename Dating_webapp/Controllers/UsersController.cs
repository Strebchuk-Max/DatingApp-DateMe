using Dating_webapp.Data;
using Dating_webapp.Entities;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace Dating_webapp.Controllers
{

    [ApiController]
    [Route("dating_webapp/[controller]")] // /dating_webapp/users
    public class UsersController : ControllerBase
    {
        private readonly DatabaseContext _context;
        public UsersController(DatabaseContext context)
        {
            _context = context;          
        }


        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers() 
        {
            var users = _context.Users.ToList();

            return users;
        }

        [HttpGet("{id}")]  // /dating_webapp/users/ip
        public ActionResult<AppUser> GetUser(int id)
        {
            var user = _context.Users.Find(id);

            return user;
        }
    }
}
