using System;
using csharpingmindApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace csharpingmindApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BlogPostController : ControllerBase
    {
        private readonly AuthsContext _context;
        public BlogPostController(AuthsContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
    }
}