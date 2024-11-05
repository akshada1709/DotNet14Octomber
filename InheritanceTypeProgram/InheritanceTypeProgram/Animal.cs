using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTypeProgram
{
    

        // 1. Single Inheritance
        public class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animal is eating.");
            }
        }

        public class Cow : Animal
        {
            public void Moo()
            {
                Console.WriteLine("Cow says moo!");
            }
        }

        // 2. Multilevel Inheritance
        public class Grandfather
        {
            public void ShareWisdom()
            {
                Console.WriteLine("Grandfather shares wisdom.");
            }
        }

        public class Father : Grandfather
        {
            public void Teach()
            {
                Console.WriteLine("Father is teaching.");
            }
        }

        public class Son : Father
        {
            public void Play()
            {
                Console.WriteLine("Son is playing.");
            }
        }

        // 3. Hierarchical Inheritance
        public class Mother
        {
            public void Care()
            {
                Console.WriteLine("Mother is caring.");
            }
        }

        public class SonOfMother : Mother
        {
            public void Study()
            {
                Console.WriteLine("Son is studying.");
            }
        }

        public class Daughter : Mother
        {
            public void Dance()
            {
                Console.WriteLine("Daughter is dancing.");
            }
        }

     }
   
