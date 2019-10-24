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
    [Route("api/doc")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        [HttpPost("save")]
        public Task<ValidityResponse> SaveDocToDatabase([FromBody] Document value)
        {
            return new DocumentService().SaveDoc(value);
        }

        // PUT: api/Document/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
