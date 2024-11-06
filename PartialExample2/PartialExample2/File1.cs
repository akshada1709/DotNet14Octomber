using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialExample2
{
    public partial class AtmMachine
    {
        private int balance = 1000;
        private string pin = "0000"; 

        public int Withdraw(int amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds.");
                return balance;
            }
            balance -= amount;
            return balance;
        }
    }
}