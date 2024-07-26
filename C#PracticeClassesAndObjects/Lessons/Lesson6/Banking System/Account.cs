using System;

namespace C_PracticeClassesAndObjects.Models.Lesson6.Banking_System
{
    public class Account
    {
        private static int nextAccountNumber = 1000;

        public int Number { get; private set; }
        public double Balance { get; private set; }
        public List<Transaction> Transactions { get; private set; }

        public Account(double initialBalance) 
        {
            Number = nextAccountNumber++;
            Balance = initialBalance; 
            Transactions = new List<Transaction>();
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Transactions.Add(new Transaction(amount, "Deposit"));
                Console.WriteLine($"Deposited amount: {amount:C} into account {Number}. New balance: {Balance:C}");
            }
            else Console.WriteLine("Deposit must be positive");
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Transactions.Add(new Transaction(amount, "Withdraw"));
                Console.WriteLine($"Withdrew amount: {amount:C} from account {Number}. New balance: {Balance:C}");
            }
            else Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
        }

        public void PrintStatement()
        {
            Console.WriteLine($"Account {Number} Statement:");
            foreach(var transaction in Transactions)
            {
                Console.WriteLine($"{transaction.Type}: {transaction.Amount:C}");
            }
            Console.WriteLine($"Current balance: {Balance:C}\n");
        }
    }
}
