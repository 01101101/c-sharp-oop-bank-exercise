using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace bank_objects
{
    class BankObjectTesting //this class is for testing purposes to random account balances and transactions and randoming the time of the transactions 
                            //maybe move this to its own file to reduce clutter
    {
        private Random rnd = new Random();

        public DateTime RandomDay()
        {
            /*var date = new DateTime(2017, 2, 1);
            var time = new TimeSpan(9, 30, 0);
            date = date.Date + time;*/

            DateTime start = new DateTime(2015, 1, 1);
            int range = (DateTime.Today - start).Days;
            DateTime returnDateTime = start.AddDays(rnd.Next(range));
            return returnDateTime;

        }

        public double RandomingAccountBalance ()//test to random a balance change to customer accounts
        {
            double RandomChangeAccountBalance = rnd.NextDouble() * (1000 - -1000) + -1000;
            return RandomChangeAccountBalance;
        }

        public double RandomingAccountStartingBalance()
        {
            double RandomStartingBalance = rnd.NextDouble() * (1000 - -1000) + -1000;
            return RandomStartingBalance;
        }

        public void PrintOutCustomerList(List<Customer> customerList )
        {
            foreach (Customer customerPrintOutVariable in customerList)
            {
                Console.WriteLine("This is your account number: " + customerPrintOutVariable.AccountNumber); //test print for customer accountnumber
            }
        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            BankObjectTesting dT = new BankObjectTesting();
           // BankAccount myBankAccount = new BankAccount();
            //Transaction myTransaction;
            Bank myBank = new Bank("SKOP");
            //Customer myCustomer = new Customer();
            //List<Transaction> transactionList = new List<Transaction>();
            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer("Mikko", "Mallikas", 
                myBank.CreateNewAccount(dT.RandomingAccountStartingBalance())));
            customerList.Add(new Customer("Paavo", "Mallikas", 
                myBank.CreateNewAccount(dT.RandomingAccountStartingBalance())));
            customerList.Add(new Customer("Mikko", "Mallikas", 
                myBank.CreateNewAccount(dT.RandomingAccountStartingBalance())));

            /*for (int i = 0; i < customerList.Count; i++) //Creating account balance number randomly
            {
                myBankAccount.AccountBalance = dT.RandomingAccountBalance();
            }*/
            
            for (int k = 0; k < customerList.Count; k++)//creating randomly transaction history to customers
            {
                for (int i = 0; i <= 10; i++)
                {
                    myBank.AddTransactionToCustomerAccount(customerList[k].AccountNumber, 
                        dT.RandomDay(), dT.RandomingAccountBalance());

                }

            }
            Console.WriteLine("Customers: ");
            dT.PrintOutCustomerList(customerList);
            
            myBank.RetrieveAllCustomerAccountBalance();

            //Asking a new Customer as a way of user input
            //Console.WriteLine("Give me your first name");
            //string inputFirstName = Console.ReadLine();
            //Console.WriteLine("Give me your last name");
            //string inputLastName = Console.ReadLine();

            for (int i = 0; i < customerList.Count;i++)
           {
               Console.WriteLine("for loop at the end: " + myBank.RetrieveCustomerAccountBalance(customerList[i].AccountNumber));
           } 
           //myBank.RetrieveAllCustomerAccountBalance();
          // myBank.RetrieveCustomerAccountTransactionHistory(customerList[random.Next(3)].AccountNumber, myBankAccount.TransactionList);      
           Console.ReadKey();
        }
    }
}
