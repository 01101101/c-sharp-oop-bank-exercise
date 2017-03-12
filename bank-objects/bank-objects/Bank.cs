using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace bank_objects
{
    class Bank
    {     

        private string _bankName;
        Random rnd = new Random();
        private List<BankAccount> _bankAccountList; //list of BankAccount objects

      /*  public Bank()
        {
            _bankName = "SKOP";
            //_customerList = new List<Customer>();
            _bankAccounts = new List<BankAccount>();
        }*/

        public Bank(string bankName)
        {
            this._bankName = bankName;
            this._bankAccountList = new List<BankAccount>();
            //CultureInfo.CurrentCulture = new CultureInfo("eu-FI");
        }

        public string BankName
        {
            get { return _bankName;}
            set { _bankName = value; }
        }


        public List<BankAccount> BankAccountList
        {
            get { return _bankAccountList; }
            set { _bankAccountList = value; }
        }

        public void AddTransactionToCustomerAccount(string accountNumber, DateTime randomDateTime, double randomSum)
        {
            for(int i = 0; i< BankAccountList.Count; i++) //iterating through bankaccountList to find the right account and adding a transaction to it
            {                                               //should be done with LINQ. if time allows will come back to this
                if(BankAccountList[i].AccountNumber == accountNumber)
                BankAccountList[i].AddCustomerAccountTransaction(new Transaction(randomDateTime, randomSum));
            }
           /* 
            Console.WriteLine("This is the transaction: " + transaction.TransactionDateTimeStamp + transaction.Sum);
            var storedVariable = BankAccountList.Where(p => p.AccountNumber == accountNumber).Select(p => p.AddCustomerAccountTransaction(new Transaction (randomDateTime, randomSum)));
            

            storedVariable.AccountBalance += randomSum;
            Console.WriteLine("this is the balance changed: " + storedVariable.AccountBalance);

            return storedVariable;*/

        }

        public string RetrieveCustomerAccountBalance(string accountNumber)
        {

            for (int i = 0; i <BankAccountList.Count;i++)
            {
                if (BankAccountList[i].AccountNumber == accountNumber)
                {
                    var message = string.Format("this is your balance1: {0}e", (BankAccountList[i].AccountBalance));
                    return message;
                }
                else
                {
                    continue;
                }

            }
            return "something went wrong";
        }

        public void RetrieveAllCustomerAccountBalance()
        {
            foreach (BankAccount tBankAccount in BankAccountList)
            {
                string message = string.Format("This is the balance: {0}",(tBankAccount.AccountBalance));
                Console.WriteLine(message);

            }     
           
        }
        public string CreateNewAccount(double accountBalance)
        {
            string accountNumber = string.Empty;
            string countryCode = "FI";

            for (int i = 0; i <= 16; i++)
            {
                string letter = rnd.Next(10).ToString();
                accountNumber = accountNumber + letter;
            }
            accountNumber = countryCode + accountNumber;
            BankAccountList.Add(new BankAccount(accountNumber, accountBalance));
            
            return accountNumber;
        }

           public void RetrieveCustomerAccountTransactionHistory(string accountNumber)
            {
            //      var storedTransactionHistory = BankAccountList.Where(p => p.AccountNumber == accountNumber).Select(p => p.RetrieveCustomerTransactionHistory());
            //  return storedTransactionHistory;
            for (int i = 0; i < BankAccountList.Count; i++)
                {

                    if (BankAccountList[i].AccountNumber == accountNumber)
                    {
                        BankAccountList[i].RetrieveCustomerTransactionHistory(BankAccountList[i].AccountBalance);
                    }
                    else
                    {
                        continue;
                    }

                }           
            }
            public void RetrieveTransactionByDate(string accountNumber, DateTime startDate, DateTime endDate) //Finding transactions between given start date and end date
            {
               for (int i = 0; i<BankAccountList.Count;i++)
                {
                    if(BankAccountList[i].AccountNumber == accountNumber)
                    {
                        BankAccountList[i].RetrieveCustomerTransactionsByDateAndTime(startDate, endDate);
                    }
                }
               /* var storedRetrievalQuery = (from BankAccount in BankAccountList
                                       where BankAccount.AccountNumber == accountNumber
                                       select BankAccount).First().RetrieveCustomerTransactionsByDateAndTime(startDate, endDate);*/

            }

    }
}

