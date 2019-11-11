using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ServiceRequestManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "service API is up and running";
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] string value)
        {
            return "Your Cheque book request has been processed";
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Your Cheque book has been blocked";
        }
    }
}
