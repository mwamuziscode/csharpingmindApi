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
        public IEnumerable<User> GetAllUsers() 
        {
            return _context.Users.ToArray();
        }
    }
}
