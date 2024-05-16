/*
using System;
using csharpingmindApi.Models; // IMPORTED
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace csharpingmindApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AuthgroupsController : ControllerBase
    {
        private readonly AuthsContext _context;
        public AuthgroupsController(AuthsContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }


        [HttpGet]
        public async Task<ActionResult> GetAllGroups()
        {
            var users = await _context.Authgroups.ToArrayAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetGroups(int id)
        {
            var user = await _context.Authgroups.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }



        [HttpPost]
        public async Task<ActionResult> PostGroups(Authgroup group)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Authgroups.Add(group);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetAllGroups),
                new { id = group.Id }, group);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> PutGroups(int id, User group)
        {
            if (id != group.Id)
            {
                return BadRequest();
            }

            _context.Entry(group).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Authgroups.Any(p => p.Id == id))
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

/*
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteGroups(int id)
        {
            var group = await _context.Groups.FindAsync(id);
            if (group == null)
            {
                return NotFound();
            }

            _context.Groups.Remove(group);
            await _context.SaveChangesAsync();

            return Ok(group);
        }


        [HttpPost("Delete")]
        public async Task<ActionResult> DeleteMultipleGroups([FromQuery] int[] ids)
        {
            var groups = new List<Group>();
            foreach (var id in ids)
            {
                var group = await _context.Groups.FindAsync(id);
                if (group == null)
                {
                    return NotFound();
                }
                groups.Add(group);
            }
            _context.Groups.RemoveRange(groups);
            await _context.SaveChangesAsync();
            return Ok(groups);
        }
        
    }
}
*/