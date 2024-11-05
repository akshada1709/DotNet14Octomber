using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rectangle rectangle = new Rectangle(34,67);
            //rectangle.Area();
            //Console.WriteLine(rectangle);

            //BankAccount ba=new SavingAccount(2500,3000);
            //ba.Deposit();
            //ba.Withdraw();

            //Triangle t=new Triangle(3,5);
            //t.CalculateArea();
            //t.calculatePerimeter();
            //Console.WriteLine(t);

            //Circle c=new Circle(3.14f,4);
            //c.CalculateArea();
            //c.calculatePerimeter();
            //Console.WriteLine(c);
            


            IFlyable fl=new Airplane();
            fl.FlyObj();
            
            IFlyable f2=new Spacecraft();
            f2.FlyObj();

            IFlyable f3= new Helicopter();
            f3.FlyObj();
        }
    }
}
