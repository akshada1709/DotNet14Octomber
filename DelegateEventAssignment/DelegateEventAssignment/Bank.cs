using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventAssignment
{
    //delegate
    public delegate int BankDelegate(int a);
    public class Bank
    {
        private int balance;
        //Create a Bank a class, with Debit & Credit method

        //If amount is greater than balance raise an event → insufficient balance
        //If balance is low(< 3000) raise an event low balance
        //If balance is zero then raise an event zero balance.
        public event BankDelegate LowBal;
        public event BankDelegate ZeroBal;
        public event BankDelegate InsuffBal;




        //You can assign a default balance using constructor
        public Bank(int initialBal)
        {
            this.balance = initialBal;
        }

        //Debit method will accept the amount that needs to be deducted from the balance.
        public int Debit(int amount) 
        {
            if (amount > balance)
            {
                Console.WriteLine("Attempting to debit amount exceeds current balance.");
                
                InsuffBal.Invoke(amount);
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Debited: {amount}, New Balance: {balance}");

                // Check if balance is low or zero after deduction
                if (balance == 0)
                {
                    ZeroBal?.Invoke(amount);
                }
                else if (balance < 3000)
                {
                    LowBal.Invoke(amount);
                }
            }
            return balance;
        }

        //Credit method will accept the amount that needs to be added in balance
        public int Credit(int amount) 
        {
            balance += amount;
            Console.WriteLine($"Credited: {amount}, New Balance: {balance}");

            
            if (balance < 3000 && balance != 0)
            {
                LowBal.Invoke(amount);
            }
            return balance;
        }
    }
}
    

