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

              DateTime startDate = new DateTime(2015, 1, 1); //arbitrarily chosen start date to start randoming dates. Could be anything
              int dayRange = (DateTime.Today - startDate).Days; //Date of now minus chosen start date to get a difference in days
              DateTime returnDateTime = startDate.AddDays(rnd.Next(dayRange)); // using the difference in the form of days as range to random date
            return returnDateTime;

        }
        public TimeSpan RandomTime()
        {
            TimeSpan randomTimeSpan = new TimeSpan(0, 0, 0, rnd.Next(86400));
            return randomTimeSpan;
            
        }

        public double RandomingAccountBalance ()//test to random a balance change to customer accounts
        {
            double RandomChangeAccountBalance = rnd.NextDouble() * (1000 - -1000) + -1000;
            return RandomChangeAccountBalance;
        }

        public double RandomingAccountStartingBalance() // randoming starting balance to created accounts
        {
            double RandomStartingBalance = rnd.NextDouble() * (1000 - -1000) + -1000;
            return RandomStartingBalance;
        }

        public void PrintOutCustomerList(List<Customer> customerList ) //a test print method
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
            List<Customer> customerList = new List<Customer>(); //a list of customers for testing
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
            DateTime startDate = new DateTime(2016, 01, 01);
            DateTime endDate = new DateTime(2017,01,01);

            for (int i = 0; i < customerList.Count;i++)
           {
                //Console.WriteLine("for loop at the end: " + myBank.RetrieveCustomerAccountBalance(customerList[i].AccountNumber));
                myBank.RetrieveTransactionByDate(customerList[i].AccountNumber, startDate, endDate);
            } 
           //myBank.RetrieveAllCustomerAccountBalance();
           myBank.RetrieveCustomerAccountTransactionHistory(customerList[random.Next(3)].AccountNumber); //randomizing which of the pre-set customers is used to print out transaction history 
           Console.ReadKey();
        }
    }
}
