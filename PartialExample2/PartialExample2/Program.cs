using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AtmMachine atm = new AtmMachine();
            Console.WriteLine("Current Balance: " + atm.CheckBalance());

            //  pin
            Console.Write("Enter a  PIN: ");
            string newPin = Console.ReadLine();
            atm.SetPin(newPin);

            // ithdraw 
            Console.Write("Enter amount to withdraw: ");
            int amount;
            if (int.TryParse(Console.ReadLine(), out amount))
            {
                int newBalance = atm.Withdraw(amount);
                Console.WriteLine("New Balance after withdrawal: " + newBalance);
            }
            else
            {
                Console.WriteLine("Invalid amount entered.");
            }

            // Check the final balance
            Console.WriteLine("Final Balance: " + atm.CheckBalance());
        }
    }
}
