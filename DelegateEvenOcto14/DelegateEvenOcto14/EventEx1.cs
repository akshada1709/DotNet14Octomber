using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvenOcto14
{
    public delegate void DisplayMessage();
    public class EventEx1
    {
        static void PassMsg()
        {
            Console.WriteLine("Congratulations ! You are pass with good score");
        }
        static void FailMsg()
        {
            Console.WriteLine("OOPs ! You are Fail");
        }

        static void Main(string[] args)
        {
            Student std = new Student();
            std.Pass += new DisplayMessage(PassMsg);
            std.Fail += new DisplayMessage(FailMsg);

            std.AcceptMarks(30);
            
        }



    }
}

