using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    class BankAccount
    {
        private string _accountNumber;
        //Transaction myTransaction = new Transaction();
        private double _accountBalance; //maybe double is not the best way to handle account balance. How about decimal or float then?
        private List<Transaction> _transactionList;
        

        public BankAccount()
        {
            _accountNumber = null;
            //_transactionHistory["5/1/2016 8:30:52 AM"] = 0.50;
            _transactionList = new List<Transaction>();
            _accountBalance = 0.0;

        }

        public BankAccount(string accountNumber, double accountBalance)
        {
            _accountNumber = accountNumber;
            _transactionList = new List<Transaction>();
            _accountBalance = accountBalance;
        }


        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public double AccountBalance
        {
            get { return _accountBalance;}
            set { _accountBalance = value; }
        }

        public List<Transaction> TransactionList
        {
            get { return _transactionList; }
           set { _transactionList = value; }
        }

       /* public List<Transaction> AddCustomerAccountTransaction(Transaction transaction)
        {

            _transactionList.Add(transaction);
            foreach (Transaction tTransaction in _transactionList)
            {
               Console.WriteLine("This is the change to account balance: " + tTransaction.Sum); 
            }

            return TransactionList; 
        }*/

        public void RetrieveCustomerTransactionsByDateAndTime()
        {
            
        }

       public void RetrieveCustomerTransactionHistory(string accountNumber)
        {
           

        }
    }
}
