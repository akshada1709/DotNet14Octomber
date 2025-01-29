using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType1
{
    public class DataType2
    {
        static void Main(string[] args)
        {
            // 1. Integral Types
            byte a = 255;         // 8-bit unsigned integer
            sbyte b = -10;        // 8-bit signed integer
            short c = 30000;      // 16-bit signed integer
            ushort d = 60000;     // 16-bit unsigned integer
            int e = 100000;       // 32-bit signed integer
            uint f = 4000000000;  // 32-bit unsigned integer
            long g = 9000000000000000000; // 64-bit signed integer
            ulong h = 18000000000000000000; // 64-bit unsigned integer

            // 2. Floating-Point Types
            float x = 3.14f;        // 32-bit floating point
            double y = 3.14159265358979; // 64-bit floating point
            decimal z = 19.99m;     // 128-bit precise decimal

            // 3. Boolean Type
            bool isAvailable = true; // True or false

            // 4. Character Type
            char letter = 'A'; // Unicode character

            // 5. String Type
            string name = "John Doe"; // Sequence of characters

            // 6. Object Type
            object obj1 = 42; // Object can store any type
            object obj2 = "Hello";

            // 7. Enum Type
            Days today = Days.Monday;
            Console.WriteLine("Today is: " + today);

            // 8. Struct Type
            Point p = new Point { X = 5, Y = 10 };
            Console.WriteLine($"Point: X = {p.X}, Y = {p.Y}");

            // 9. Class Type
            Person person = new Person();
            person.Name = "Alice";
            Console.WriteLine("Person Name: " + person.Name);

            // 10. Array Type
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array Element: " + numbers[0]);

            // 11. List (Reference Type)
            List<string> cities = new List<string> { "New York", "London", "Mumbai" };
            Console.WriteLine("List First Element: " + cities[0]);

            // 12. Dictionary (Reference Type)
            Dictionary<int, string> students = new Dictionary<int, string>
            {
                { 1, "John" },
                { 2, "Alice" }
            };
            Console.WriteLine("Dictionary Value: " + students[1]);

            // 13. Nullable Type
            int? nullableInt = null;
            Console.WriteLine("Nullable Value: " + (nullableInt ?? 0)); // Default 0 if null

            // 14. Interface Implementation
            Dog dog = new Dog();
            dog.Speak();

            Console.ReadLine(); // Pause console
        }
    }

    // Enum Example
    enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

    // Struct Example
    struct Point
    {
        public int X;
        public int Y;
    }

    // Class Example
    class Person
    {
        public string Name;
    }

    // Interface Example
    interface IAnimal
    {
        void Speak();
    }

    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Dog says: Bark!");
        }
    }
}

