using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    class BankAccount
    {
        private int _accountNumber;

        public string AccountTransaction()
        {
            return"AccountTransaction";
        }

        public string AccountBalance()
        {
            return"Balance";
        }

        public string AddTransaction()
        {
            return "Transaction";
        }

        public string RetrieveTransactionHistory()
        {
            
            return "TransactionHistory";
        }
    }
}
