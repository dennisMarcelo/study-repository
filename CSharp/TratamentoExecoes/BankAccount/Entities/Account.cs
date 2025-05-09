﻿using BankAccount.Entities.Exceptions;

namespace BankAccount.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            if(amount < 0)
            {
                throw new DomainException("Amount less than 0 (zero)");
            }

            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            if(amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return $"New balance: {Balance}";
        }
    }
}
