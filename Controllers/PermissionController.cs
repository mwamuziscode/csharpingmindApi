using System;
using csharpingmindApi.Models; // IMPORTED
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace csharpingmindApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PermissionController : ControllerBase
    {
        private readonly AuthsContext _context;
        public PermissionController(AuthsContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<ActionResult> GetAllPermisions()
        {
            return Ok(await _context.Permissions.ToArrayAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetPermission(int id)
        {
            var perms = await _context.Permissions.FindAsync(id);
            if (perms == null)
            {
                return NotFound();
            }
            return Ok(perms);
        }



        [HttpGet("{contentTypeId}")]
        public async Task<ActionResult> GetPermissionContentTypeId(int contentTypeId)
        {
            var perms = await _context.Permissions.FindAsync(contentTypeId);
            if (perms == null)
            {
                return NotFound();
            }
            return Ok(perms);
        }


        [HttpPost]
        public async Task<ActionResult> PostPermission(Permission permission)
        {
            if (permission == null)
            {
                return NotFound();
            }

            await _context.Permissions.AddAsync(permission);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAllPermisions), new { id = permission.Id });
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePermissions(int id)
        {
            var perm = await _context.Permissions.FindAsync(id);
            if (perm == null)
            {
                return NotFound();
            }

            _context.Permissions.Remove(perm);
            await _context.SaveChangesAsync();
            return Ok(perm);
        }



        [HttpPut("{id}")]
        public async Task<ActionResult> PutPermissions(int id, User perm)
        {
            if (id != perm.Id)
            {
                return BadRequest();
            }

            _context.Entry(perm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Permissions.Any(p => p.Id == id))
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





    }
}
