using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionsManagement.DTO
{
    public class TransferDTO
    {
        public int From { get; set; }
        public int To { get; set; }
        public int Amount { get; set; }

    }
}
