using System;

namespace C_PracticeClassesAndObjects.Models.Lesson6.Banking_System
{
    public class Transaction
    {
        public double Amount { get; set; }
        public string Type { get; set; }

        public Transaction(double amount, string type)
        {
            Amount = amount;
            Type = type;
        }
    }
}
