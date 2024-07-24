using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Models.Lesson6.Banking_System
{
    public class BankingOperations
    {

        public void Initializing()
        {
            Customer johnnyDepp = new Customer("Johnny Depp");
            Customer rossGeller = new Customer("Ross Geller");
            Customer peterParker = new Customer("Peter Parker");

            Account deppAccount1 = new Account(9000);
            Account deppAccount2 = new Account(13000);
            Account gellerAccount1 = new Account(4000);
            Account parkerAccount1 = new Account(300);
            Account parkerAccount2 = new Account(9000);

            johnnyDepp.AddAccount(deppAccount1);
            johnnyDepp.AddAccount(deppAccount2);
            rossGeller.AddAccount(gellerAccount1);
            peterParker.AddAccount(parkerAccount1);
            peterParker.AddAccount(parkerAccount2);

            deppAccount1.Withdraw(400);
            gellerAccount1.Deposit(600);
            parkerAccount2.Withdraw(900);
            parkerAccount1.Deposit(900);

            johnnyDepp.GetTotalBalance();
            rossGeller.GetTotalBalance();
            peterParker.GetTotalBalance();

            deppAccount1.PrintStatement();
            parkerAccount2.PrintStatement();
            parkerAccount1.PrintStatement();

            johnnyDepp.IsMoreThanOneAccount();
            rossGeller.IsMoreThanOneAccount();
        }
    }
}
