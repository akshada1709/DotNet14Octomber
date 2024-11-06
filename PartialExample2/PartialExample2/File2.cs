using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialExample2
{
    public partial class AtmMachine
    {
        public void SetPin(string newPin)
        {
            if (newPin.Length == 4) 
            {
                pin = newPin;
                Console.WriteLine("PIN updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid PIN. Please enter a 4-digit PIN.");
            }
        }
    }
}
