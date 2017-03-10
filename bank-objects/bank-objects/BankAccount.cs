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

       public void AddCustomerAccountTransaction(Transaction transaction)
        {

            _transactionList.Add(transaction);
  

            //return TransactionList; 
        }

        public void RetrieveCustomerTransactionsByDateAndTime()
        {
            //return ;   
        }

       public void RetrieveCustomerTransactionHistory(double accountBalance)
        {

            string TransactionHistoryString;
            for (int i = 0; i< _transactionList.Count;i++)
            {
                double summedUp = accountBalance + _transactionList[i].Sum;
                TransactionHistoryString = string.Format("Account balance:{0} EURO -- Transaction sum: {1} EURO -- Transaction date: {2}\n -- Account Balance after transaction: {3} EURO",accountBalance,  _transactionList[i].Sum.ToString(), _transactionList[i].TransactionDateTimeStamp.ToString(),summedUp);
                Console.WriteLine(TransactionHistoryString);
            }
            

        }
    }
}
