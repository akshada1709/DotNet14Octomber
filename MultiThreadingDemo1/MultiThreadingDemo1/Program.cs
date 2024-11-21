using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingDemo1
{
    public class Test
    {
        public void M1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);//pause thread for some time
            }
        }
        public void M2()
        {
            for (int i = 6; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);

            }
        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Test test = new Test();
    //        // test.M1();//normal way to
    //        // test.M2();
    //        Thread t1 = new Thread(new ThreadStart(test.M1));// ThreadStart is a delegate
    //        // it will hold method ref that need to exec by the thread
    //        Thread t2 = new Thread(new ThreadStart(test.M2));

    //    }
    //}
}
