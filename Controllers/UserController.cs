using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace csharpingmindApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        [HttpGet]
        public string GetUser() 
        {
            return "Hello World";
        }
    }
}
