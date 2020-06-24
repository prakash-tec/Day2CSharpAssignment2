using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_2
{
  
        enum TransactionType
        {
            DEPOSIT, WITHDRAW
        }
        class Banking
        {
        private long accountNo;
        private string customerName;
        private string accountType;
        private TransactionType transaction;
        private double amount;
        private double balance;

        public Banking() { /*Default Constructor*/ }

        public long AccountNo { get => accountNo; set => accountNo = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public double Amount { get => amount; set => amount = value; }
        public double Balance { get => balance; set => balance = value; }
        public string AccountType { get => accountType; set => accountType = value; }
        internal TransactionType Transaction { get => transaction; set => transaction = value; }

        public double DoDeposit(Banking b1)
        {
            return balance + b1.Amount;
        }
        public double DoWithdraw(Banking b1)
        {
            return balance - b1.Amount;
        }
        public void Display()
        {
            Console.WriteLine("\nAccount Name : " + CustomerName + "\nAccount Number : " + AccountNo + "\nBalance : " + Balance);
        }
    }
}
    

