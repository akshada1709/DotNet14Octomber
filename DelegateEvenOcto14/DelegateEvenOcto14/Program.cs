using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvenOcto14
{
    public class Program
    {
        //static void Main(string[] args)
        //{

        //    //for Delegate DelegatesEx1
        //    //class obj
        //    //DelegatesEx1 dg = new DelegatesEx1();

        //    // delegate object            
        //    //MyDelegate obj=new MyDelegate(dg.Add);
        //    //int result = obj.Invoke(12, 40);
        //    //Console.WriteLine(result);

        //    //for Multicast Delegates
        //    MultiCastDeleEx mul =new MultiCastDeleEx();
        //    MyDelegate2 obj2 = new MyDelegate2(mul.Sub);
        //    obj2 += new MyDelegate2(mul.Add);// add in to the invocation list

        //    obj2 += new MyDelegate2(mul.Multiply);
        //    //obj2 -= new MyDelegate2(mul.Sub); // -= will remove method from invocation list

        //    // Delegate will create the invocationList 
        //    // invocationList hold methods refer in the same sequence that we have added
        //    // basic need of multicast delegate is --> to invoke methods in a sequence.

        //    Delegate[] list=obj2.GetInvocationList();
        //    foreach (Delegate item in list)
        //    {
        //        Console.WriteLine(item.Method);
        //        Console.WriteLine(item.DynamicInvoke(23,67));
                
        //    }

        //    //User u = new User();
        //    //Mydelegate2 obj2 = new Mydelegate2(u.AcceptName);
        //    //Console.WriteLine(obj2.Invoke("ThinkQuotient"));
        //    //c.Add(20, 30);


        //}
    }
}
