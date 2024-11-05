using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment1
{
    public class CurrentAccount: BankAccount
    {
        private double amount;
        private double balance;

        public CurrentAccount(double amount, double balance)
        {
            this.amount = amount;
            this.balance = balance;
        }

        public override void Deposit()
        {
            balance = balance + amount;
            Console.WriteLine($"{amount} deposit succesfull  from  current account"); 
        }

        public override void Withdraw()
        {
            balance = balance + amount;
            Console.WriteLine($"{amount} deposit succesfull from  current account"); 
        }
    }
}
