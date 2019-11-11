using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountsManagement
{
    public class AccountDTO
    {
        public int AccountNumber { get; set; }
        public int UserId { get; set; }
        public string Balance { get; set; }
        public string Branch { get; set; }
    }
}
