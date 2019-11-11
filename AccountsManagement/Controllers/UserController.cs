using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountsManagement.Config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AccountsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ConfigSettings configSettings { get; set; }

        Database db;
        public UserController(IOptions<ConfigSettings> settings)
        {
            configSettings = settings.Value;
            db = new Database();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            if (string.IsNullOrEmpty(configSettings.Bank))
            {
                return "Welcome to my bank User";
            }
            else
            {
                return "Welcome to bank : " + configSettings.Bank;
            }
        }
        
        // POST api/values
        [HttpPost]
        public string Post([FromBody] UserDTO value)
        {
            db.AddUser(value);
            return "User Added successfully";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] UserDTO value)
        {
            if(db.UpdateUser(value, id))
            {
                return "User updated successfully";
            }
            else
            {
                return "UserId is wrong";
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            db.CloseAccount(id);
            return "Your account is closed";
        }
    }
}
