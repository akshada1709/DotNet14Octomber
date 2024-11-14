using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StringAssignment1
{
    public class FindCommEle
    {
        public static void Main(string[] args)
        {
            // Two sample string arrays
            string[] array1 = { "apple", "banana", "cherry", "date" };
            string[] array2 = { "cherry", "apple", "fig", "grape", "banana" };

            // Array to store common elements with a fixed size
            string[] commonElements = new string[Math.Min(array1.Length, array2.Length)];
            int count = 0;

            // Find common elements using nested loops
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j]) // Check if elements are equal
                    {
                        bool alreadyExists = false;

                        // Check if element is already in commonElements to avoid duplicates
                        for (int k = 0; k < count; k++)
                        {
                            if (commonElements[k] == array1[i])
                            {
                                alreadyExists = true;
                                break;
                            }
                        }

                        // Add to commonElements if not already added
                        if (!alreadyExists)
                        {
                            commonElements[count] = array1[i];
                            count++;
                        }
                    }
                }
            }

            // Display the common elements
            Console.WriteLine("Common elements:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(commonElements[i]);
            }
        }
    }
}

