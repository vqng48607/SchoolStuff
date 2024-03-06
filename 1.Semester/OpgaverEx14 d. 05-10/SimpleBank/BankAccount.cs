using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    public class BankAccount
    {
        private double balance;
        private bool locked;
        public string Name { get; set; }
        public double Balance 
        {
            get
            {
                return balance;
            }
        }

        public BankAccount(string name, double balance, bool locked)
        {
            Name = name;
            this.balance = balance;
            this.locked = locked;
        }

        public BankAccount(string name, double balance):
            this(name, balance, false)
        {
        }

        public BankAccount(double balance):
            this("", balance, false)
        {
        }
        
        public void Deposit(double amount)
        {
            if (locked == true)
            {
                Console.WriteLine("You can't deposit the amount, because your bankaccount is locked");
            }
            else
            {
                balance = Balance + amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount || locked == true)
            {
                Console.WriteLine("You can't withdraw because either your amount is too high or your bankaccount is locked");
            }
            else
            {
                balance = Balance - amount;
            }

        }

        public void ChangeLockState()
        {
            if (locked == false)
                locked = true;

            else if (locked == true)
                locked = false; ;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Balance: " + Balance;
        }
    }

   
}
