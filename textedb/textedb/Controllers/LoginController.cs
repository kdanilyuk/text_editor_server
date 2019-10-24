using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using textedb.Models;
using textedb.Services;

namespace textedb.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // GET api/login
        [HttpGet("{login}/{password}")]
        public Task<User> Get(string login, string password)
        {
            return new LoginService().Login(login, password);
        }
    }
}
