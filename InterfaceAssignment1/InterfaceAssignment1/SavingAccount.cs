using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment1
{
    public class SavingAccount:BankAccount
    {

        private double amount;
        private double balance;

        public SavingAccount(double amount, double balance) 
        {
          this.amount = amount;
          this.balance = balance;
        }

        public override void Deposit()
        {
            balance = balance+amount;
            Console.WriteLine($"{amount} deposit succesfull from saving account and balance is : {balance}");
        }
        public override void Withdraw()
        {
            balance= balance-amount;
            Console.WriteLine($"{amount} withdraw succesfull  from saving account and balance is {balance}");
        }

       
    }
}
