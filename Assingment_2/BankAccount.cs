using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_2
{
    class BankAccount
    {
        public String ownerName;
        public String accNumber;
        public string typeAccount;
        public double balance;
        public void setOwner(String name)
        {
            ownerName = name;
        }
        public void setNumber(String number)
        {
            accNumber = number;
        }
        public void setType(string type)
        {
            typeAccount = type;
        }
        public void setBalance(double amount)
        {
            if (amount >= 0)
            {
                balance = amount;
            }
            else
                Console.WriteLine("Error: Invalid amount!");
        }
        public void deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
                Console.WriteLine("Error: Invalid amount!");
        }
        public void withdraw(double amount)
        {
            if (amount > 0 && amount < balance)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Error: Insufficient found or invalid amount!");
        }
        public void display()
        {
            Console.WriteLine("Account owner’s name: "+ownerName);
            Console.WriteLine("Account balance: "+balance);
        }
    }
    class BankAccount_Test1
    {
       public static void Main()
        {
            BankAccount bank = new BankAccount();
            bank.accNumber = "501007752438383";
            bank.ownerName = "prakash patra";
            bank.balance = 1000;
            bank.typeAccount = "saving";
            bank.setBalance(500);
            bank.deposit(1500);
            bank.withdraw(1000);
            bank.display();
            Console.ReadKey();
        }
    }
    
}

