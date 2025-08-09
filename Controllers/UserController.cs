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
        private readonly UsersContext _context;
        public UserController(UsersContext context)
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
        [HttpGet("user/{isActive}")]
        public async Task<ActionResult<IEnumerable<User>>> GetAvailableUser()
        {
            var users = await _context.Users.Where(u => u.IsActive && u.Age >= 30).ToArrayAsync();
            return users;
        }

        /*  get user by id*/
        [HttpGet("group/{ByGroupId}")]
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

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetAllUsers),
                new {id = user.Id }, user );
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Users.Any(p => p.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Ok(user);
        }


        [HttpPost("Delete")]
        public async Task<ActionResult> DeleteMultiple([FromQuery] int[] ids)
        {
            var users = new List<User>();
            foreach (var id in ids)
            {
                var user = await _context.Users.FindAsync(id);
                if (user == null)
                {
                    return NotFound();
                }
                users.Add(user);
            }
            _context.Users.RemoveRange(users);
            await _context.SaveChangesAsync();
            return Ok(users);
        }
    }
}
