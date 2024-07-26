using System;

namespace C_PracticeClassesAndObjects.Models.Lesson6.Banking_System
{
    public class Customer
    {
        public string Name { get; set; }
        public List<Account> Accounts { get; set; }

        public Customer (string name)
        {
            Name = name;
            Accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        public void GetTotalBalance()
        {
            double totalBalance = 0;

            foreach (var account in Accounts)
            {
                totalBalance += account.Balance;
            }
            Console.WriteLine($"Total balance is: {totalBalance}");
        }

        public void IsMoreThanOneAccount()
        {
            double totalBalance = 0;

            if (Accounts.Count > 1)
            {
                Console.WriteLine($"{Name} has more than one account.");
                foreach (var account in Accounts)
                {
                    totalBalance += account.Balance;
                }
                Console.WriteLine($"Total balance of {Name} accounts is: {totalBalance}");
            }
            else
            {
                Console.WriteLine($"{Name} has not more than one account.");
            }
        }
    }
}
