using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using csharpingmindApi.Models.Contexted;





namespace csharpingmindApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class GroupController : ControllerBase
    {
        private readonly UsersContext _context;
        public GroupController(UsersContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<ActionResult> GetAllGroups()
        {
            var groups = await _context.Users.Select(u => u.Group).Distinct().ToArrayAsync();
            return Ok(groups);
        }
    }

}
    