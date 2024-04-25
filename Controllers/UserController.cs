using System;
using csharpingmindApi.Models; // IMPORTED
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace csharpingmindApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly AuthsContext _context;
        public UserController(AuthsContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }


        [HttpGet]
        public async Task<ActionResult> GetAllUsers() 
        {
            var users = await _context.Users.ToArrayAsync();
            return Ok(users);
        }

        /*  get user by id*/
        [HttpGet("{id}")]
        public async Task<ActionResult> GetUser(int id)
        {
            //return _context.Users.SingleOrDefault(u => u.Id == id);
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        

        // get user by id
        [HttpGet("{isActive}")]
        public async Task<ActionResult<IEnumerable<User>>> GetAvailableUser()
        {
            var users = await _context.Users.Where(u => u.IsActive && u.Age >= 30).ToArrayAsync();
            return users;
        }

        /*  get user by id*/
        [HttpGet("{ByGroupId}")]
        public async Task<ActionResult> GetUserByGroupId(int ByGroupId)
        {
            var user = await _context.Users.FindAsync(ByGroupId);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult> PostUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetAllUsers),
                new {id = user.Id }, user );
        }


        //[HttpPut]



    }
}
