using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment1
{
    //1.Write a C# program to create an interface Flyable with a method called FlyObj(). Create three classes Spacecraft,
    //Airplane, and Helicopter that implement the Flyable interface. Implement the FlyObj() method for each of the three classes
    public interface IFlyable
    {
        void FlyObj();
    }

    public class Airplane : IFlyable
    {
        public void FlyObj()
        {
            Console.WriteLine("Airplan fly"); ;
        }
    }
    public class Helicopter : IFlyable
    {
        public void FlyObj()
        {
            Console.WriteLine("Helicopte fly"); ;
        }
    }

    public class Spacecraft : IFlyable
    {
        public void FlyObj()
        {
            Console.WriteLine("Spacecraft fly"); ;
        }
    }
}
