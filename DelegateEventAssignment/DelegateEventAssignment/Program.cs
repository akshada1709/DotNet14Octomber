using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {

            Bank bk = new Bank(5000);

            BankDelegate bd = new BankDelegate(bk.Credit);
            bd += new BankDelegate(bk.Debit);

            



        }
    }
}
