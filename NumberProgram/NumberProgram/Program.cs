using System;
using System.Collections.Generic;

namespace NumberProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test each method with example inputs
            Console.WriteLine("Fibonacci (10th): " + Fibonacci(10));
            Console.WriteLine("Is Prime (29): " + IsPrime(29));
            Console.WriteLine("Factorial (5): " + Factorial(5));
            Console.WriteLine("Reverse Integer (12345): " + ReverseInteger(12345));
            Console.WriteLine("Sum of Digits (123): " + SumOfDigits(123));
            Console.WriteLine("Count Digits (12345): " + CountDigits(12345));
            Console.WriteLine("Is Palindrome (121): " + IsPalindrome(121));
            Console.WriteLine("GCD (54, 24): " + GCD(54, 24));
            Console.WriteLine("Is Armstrong (153): " + IsArmstrong(153));
            Console.WriteLine("Finding Missing Number: " + FindMissingNumber(new int[] { 0, 1, 2, 4, 5 }));
            Console.WriteLine("Two Sum (array: [2, 7, 11, 15], target: 9): " + string.Join(", ", TwoSum(new int[] { 2, 7, 11, 15 }, 9)));
            Console.WriteLine("Maximum Subarray Sum: " + MaxSubarraySum(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
            Console.WriteLine("Is Power of Two (16): " + IsPowerOfTwo(16));
            Console.WriteLine("Digit Frequency (122333): " + string.Join(", ", DigitFrequency(122333)));
            Console.WriteLine("Nth Triangular Number (5): " + TriangularNumber(5));
            Console.WriteLine("Sum of Primes (10): " + SumOfPrimes(10));
            Console.WriteLine("Find Duplicates: " + string.Join(", ", FindDuplicates(new int[] { 1, 2, 3, 2, 3, 4 })));
            Console.WriteLine("Decimal to Binary (10): " + DecimalToBinary(10));
            Console.WriteLine("Nth Ugly Number (10): " + NthUglyNumber(10));
            Console.WriteLine("Pythagorean Triplet: " + HasPythagoreanTriplet(new int[] { 3, 1, 4, 6, 5 }));
        }

        // 1. Fibonacci Sequence
        static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        // 2. Prime Number Check
        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        // 3. Factorial Calculation
        static long Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }

        // 4. Reverse an Integer
        static int ReverseInteger(int num)
        {
            int reversed = 0;
            while (num != 0)
            {
                reversed = reversed * 10 + num % 10;
                num /= 10;
            }
            return reversed;
        }

        // 5. Sum of Digits
        static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        // 6. Count Digits
        static int CountDigits(int num)
        {
            return num.ToString().Length;
        }

        // 7. Palindrome Number
        static bool IsPalindrome(int num)
        {
            int original = num, reversed = 0;
            while (num > 0)
            {
                reversed = reversed * 10 + num % 10;
                num /= 10;
            }
            return original == reversed;
        }

        // 8. Greatest Common Divisor (GCD)
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // 9. Armstrong Number
        static bool IsArmstrong(int num)
        {
            int sum = 0, original = num, digits = num.ToString().Length;
            while (num > 0)
            {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, digits);
                num /= 10;
            }
            return sum == original;
        }

        // 10. Finding Missing Number
        static int FindMissingNumber(int[] arr)
        {
            int n = arr.Length;
            int total = (n * (n + 1)) / 2;
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return total - sum;
        }

        // 11. Two Sum Problem
        static int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[nums[i]] = i;
            }
            return new int[] { };
        }

        // 12. Maximum Subarray Sum (Kadane's Algorithm)
        static int MaxSubarraySum(int[] nums)
        {
            int maxSoFar = nums[0], maxEndingHere = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                maxEndingHere = Math.Max(nums[i], maxEndingHere + nums[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }
            return maxSoFar;
        }

        // 13. Power of Two
        static bool IsPowerOfTwo(int num)
        {
            return (num > 0) && (num & (num - 1)) == 0;
        }

        // 14. Digit Frequency
        static Dictionary<int, int> DigitFrequency(int num)
        {
            var frequency = new Dictionary<int, int>();
            while (num > 0)
            {
                int digit = num % 10;
                if (frequency.ContainsKey(digit))
                    frequency[digit]++;
                else
                    frequency[digit] = 1;
                num /= 10;
            }
            return frequency;
        }

        // 15. N-th Triangular Number
        static int TriangularNumber(int n)
        {
            return (n * (n + 1)) / 2;
        }

        // 16. Sum of Prime Numbers
        static int SumOfPrimes(int limit)
        {
            int sum = 0;
            for (int i = 2; i <= limit; i++)
            {
                if (IsPrime(i))
                    sum += i;
            }
            return sum;
        }

        // 17. Find Duplicates
        static List<int> FindDuplicates(int[] arr)
        {
            var duplicates = new HashSet<int>();
            var seen = new HashSet<int>();
            foreach (int num in arr)
            {
                if (!seen.Add(num))
                {
                    duplicates.Add(num);
                }
            }
            return new List<int>(duplicates);
        }

        // 18. Decimal to Binary
        static string DecimalToBinary(int num)
        {
            return Convert.ToString(num, 2);
        }

        // 19. N-th Ugly Number
        static int NthUglyNumber(int n)
        {
            int[] ugly = new int[n];
            ugly[0] = 1;
            int i2 = 0, i3 = 0, i5 = 0;
            int next2 = 2, next3 = 3, next5 = 5;

            for (int i = 1; i < n; i++)
            {
                int nextUgly = Math.Min(next2, Math.Min(next3, next5));
                ugly[i] = nextUgly;

                if (nextUgly == next2)
                {
                    i2++;
                    next2 = ugly[i2] * 2;
                }
                if (nextUgly == next3)
                {
                    i3++;
                    next3 = ugly[i3] * 3;
                }
                if (nextUgly == next5)
                {
                    i5++;
                    next5 = ugly[i5] * 5;
                }
            }
            return ugly[n - 1];
        }

        // 20. Pythagorean Triplet
        static bool HasPythagoreanTriplet(int[] arr)
        {
            int n = arr.Length;
            Array.Sort(arr);
            for (int i = n - 1; i >= 2; i--)
            {
                int a = 0, b = i -
