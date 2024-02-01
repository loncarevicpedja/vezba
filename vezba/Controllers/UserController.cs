using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vezba.Context;
using vezba.Models;

namespace vezba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        public UserController(AppDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _context.users.ToListAsync();
        }
    }
}
