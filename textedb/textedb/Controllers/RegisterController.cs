using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using textedb.Models;
using textedb.Services;

namespace textedb.Controllers
{
    [Route("api/register")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        // GET: api/Register
        [HttpGet("{login}/{password}")]
        public Task<User> Get(string login, string password)
        {
            return new RegisterService().Register(login, password);
        }
    }
}
