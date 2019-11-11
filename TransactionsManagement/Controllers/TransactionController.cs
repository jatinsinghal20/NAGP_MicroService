using Microsoft.AspNetCore.Mvc;
using TransactionsManagement.DTO;

namespace TransactionsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Transaction API is up";
        }
        
        // POST api/values
        [HttpPost("withdrawal")]
        public string Withdrawal([FromBody] WithdrawDTO value)
        {
            return "Deposited successfully";
        }

        [HttpPost("deposit")]
        public string Deposit([FromBody] WithdrawDTO value)
        {
            return value.Amount + " Deposited successfully";
        }

        [HttpPost("transfer")]
        public string Transfer([FromBody] TransferDTO value)
        {
            return value.Amount + " transferrred to "+ value.To+ " successfully";
        }
    }
}
