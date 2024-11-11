using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderEx1
{
    public class NameException:Exception
    {
        public NameException(string msg):base(msg) 
        {
           
        }

        public class User 
        {
            private string name;

            public User(string name) 
            {
                //check name is null,isempty,whitespace
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new NameException("Name cannot null,empty,whitespace");

                }
                else 
                {
                   this.name = name;
                }
            }
        }

        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        //User us = new User(" ");
        //        User us = new User("akshada");
        //        Console.WriteLine("User created successfully.");

        //    }
        //    catch (NameException e) 
        //    {
        //        Console.WriteLine(e.Message);
        //    }


        //}
    }
}
