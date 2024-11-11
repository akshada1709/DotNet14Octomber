using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderEx1
{
    public class AgeException:Exception
    {

        public AgeException(string msg):base(msg) 
        {
           
        }

        public class User 
        {
            private int age;

            public User(int age)
            {
                if (age >= 18)
                {
                    Console.WriteLine($"{age} is valid");
                }
                else 
                {
                    throw new AgeException($"{age} is not valid");
                }
            }

            
        }


        static void Main(string[] args)
        {
            try
            {
                User us = new User(15);

            }
            catch (AgeException e) 
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
