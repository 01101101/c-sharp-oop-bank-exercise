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

        public BankAccount AddTransactionToCustomerAccount(string accountNumber, DateTime randomDateTime, double randomSum)
        {
            Transaction transaction = new Transaction(randomDateTime, randomSum);
            Console.WriteLine("This is the transaction: " + transaction.TransactionDateTimeStamp + transaction.Sum);
            var storedVariable = BankAccountList.Find(p => p.AccountNumber == accountNumber);
            
            storedVariable.AccountBalance += randomSum;
            Console.WriteLine("this is the balance changed: " + storedVariable.AccountBalance);

            return storedVariable;

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

        /*    public void RetrieveCustomerAccountTransactionHistory(string accountNumber)
            {
                for (int i = 0; i < BankAccountList.Count; i++)
                {

                    if (BankAccountList[i].AccountNumber == accountNumber)
                    {
                        Console.WriteLine("Account number: " + accountNumber + "\n" + "Transaction History");
                        for (int k = 0; k < transactionList.Count; k++)
                        {
                            string message = string.Format("Amount and time: {0}e : {1}",
                                transactionList[k].Sum, transactionList[k].TransactionDateTimeStamp);
                            Console.WriteLine(message);
                        }
                    }
                    else
                    {
                        continue;
                    }

                }


            }*/

    }
}

