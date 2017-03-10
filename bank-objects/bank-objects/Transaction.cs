using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    class Transaction
    {
        private DateTime _transactionDateTimeStamp;
        private double _sum;

        /*public Transaction ()
        {
            _transactionDateTimeStamp = Convert.ToDateTime("5 / 1 / 2013 8:30:52 AM");
            _sum = _sum - 0.25;
        }*/

        public Transaction(DateTime transactionDateTimeStamp, double sum)
        {
            this._transactionDateTimeStamp = transactionDateTimeStamp;
            this._sum = sum;
        }

        public DateTime TransactionDateTimeStamp
        {
            get { return _transactionDateTimeStamp;}
            set { _transactionDateTimeStamp = value; }
        }

        public double Sum
        {
            get { return _sum;}
            set { _sum = value; }
        } 
    }
}
