using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    class Bank
    {

        Random rnd = new Random();
        private string _bankName;
        public List<string> bankAccounts = new List<string>();
        private List<string> transactionList = new List<string>();

        Dictionary<List<string>, string> customerList = new Dictionary<List<string>, string>();
        Dictionary<List<string>, List<string>> customerTransactionList = new Dictionary<List<string>, List<string>>();

        /*public string RetrieveCustomerTransaction(Dictionary<List<string>, List<string>> customerTransactionList)
        {
            foreach (accountNumber acountNumberFind in customerTransactionList)
            {
                
            }
            return "RetrieveCustomerTransaction";
        }*/

        public string RetrieveCustomerAccountBalance()
        {
            return "CustomerAccountBalance";
        }

        public IList<string> AddCustomerAccountTransaction(List<string> transactionList, List<string> accountNumber )
        {
            var date = new DateTime(2017,2,1);
            var time = new TimeSpan(9,30,0);
            date = date.Date + time;
            transactionList.Add(date.ToString());

            return transactionList;
        }

        public IList<string> CreateNewAccount(List<string>bankAccounts)
        {
            string countryCode = "FI";
            string restAccountNumbers = rnd.Next(16).ToString();
            string accountNumber = countryCode + restAccountNumbers;
            bankAccounts.Add(accountNumber);

            return bankAccounts;
        }

        public string FindAccountNumber(Dictionary<string, string> customerTransactionList, Dictionary<string, string> customerList   )
        {
            foreach (KeyValuePair<string, string> accountNumber in customerTransactionList )
            {
                Console.WriteLine(accountNumber);
            }
            return "JOHAN JYTISEE";
        }
    }

}
