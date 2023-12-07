using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class BankAccount
    {
        private string accountNumber;
        private decimal balance;

        //constructor
        public BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
            //default balance 
            this.balance = 0;
        }
        //method
        public void Deposit(decimal amount)
        {
            balance = balance + amount;
        }
        public void Withdraw(decimal amount) 
        {
            balance = balance - amount;
            //if(amount < balance)
            //{
            //    balance = balance - amount;
            //}
            //else
            //{
            //    Console.WriteLine("Sorry !! Not enough money");
            //}
        }

        //method
        public void output()
        {
            Console.WriteLine($" The Final Balance of '{accountNumber}' after withdraw is Rs {balance}.");
        }
    }
}
