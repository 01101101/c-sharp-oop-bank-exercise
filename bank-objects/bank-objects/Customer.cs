using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    class Customer
    {
        private string _firstName;
        private string _lastName;
        private string _accountNumber;

        //Default Constructor
       /* public Customer()
        {
            _firstName = null;//"Maija";
                _lastName = null; //"Meikäläinen";
                    _accountNumber = null; //"FI1234567891234567";
        }*/

        //Constructor with Parameters
        public Customer(string firstName, string lastName, string accountNumber)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._accountNumber = accountNumber;
        }

        public string FirstName
        {
            get { return _firstName;}
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public override string ToString()
        {
            return Print();
        }

        public string Print()
        {
            return "Customer: " + _firstName + " " + _lastName + " Account Number: " + _accountNumber;
        }
    }
}
