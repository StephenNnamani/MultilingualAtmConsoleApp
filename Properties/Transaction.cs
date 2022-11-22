using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtmConsoleAppInThreeLanguages.Enums;

namespace AtmConsoleAppInThreeLanguages.Properties
{
    internal class Transaction
    {
        private long TransactionId { get; set; }
        private long UserBankId { get; set; }
        private string Description { get; set; }
        private DateTime TransactionDate { get; set; }
        private TransactionType TransType { get; set; }
        private decimal TransactionAmount { get; set; }
    }
}
