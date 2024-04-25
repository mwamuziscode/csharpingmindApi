using System;
using csharpingmindApi.Models; // IMPORTED
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

/*
namespace csharpingmindApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class GroupController : ControllerBase
    {
        private readonly AuthsContext _context;
        public GroupController(AuthsContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }


        [HttpGet]
        public ActionResult GetAllGroups()
        {
            return Ok(_context.Groups.ToArray());
        }
    }
}
*/