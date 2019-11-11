using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionsManagement.DTO
{
    public class WithdrawDTO
    {
        public int AccountNumber { get; set; }
        public int Amount { get; set; }
    }
}
