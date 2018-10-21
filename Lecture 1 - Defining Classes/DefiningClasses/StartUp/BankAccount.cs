using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {
        private int id;
        private decimal balance;

        public BankAccount()
        {
            this.Id = 0;
            this.Balance = 0;
        }

        public BankAccount(int id)
        {
            this.Id = id;

        }
        public BankAccount(int id, decimal balance) : this(id)
        {
            this.Balance = balance;
        }
        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (this.balance >= amount)
            {
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }

        public override string ToString()
        {
            return ($"Account ID{this.Id}, balance {this.Balance:F2}");
        }
    }
}
