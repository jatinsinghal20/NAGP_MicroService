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
    public class AccountsController : ControllerBase
    {
        ConfigSettings configSettings { get; set; }

        Database db;
        public AccountsController(IOptions<ConfigSettings> settings)
        {
            configSettings = settings.Value;
            db = new Database();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<AccountDTO>> Get()
        {
            return db.GetAllAccounts();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<List<AccountDTO>> Get(int id)
        {
            return db.GetAccountsByUserId(id);
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] AccountDTO value)
        {
            db.AddAccount(value);
            return "Account Added successfully";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] AccountDTO value)
        {
            if(db.UpdateAccount(value, id))
            {
                return "Account updated successfully";
            }
            else
            {
                return "Account number is wrong";
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
