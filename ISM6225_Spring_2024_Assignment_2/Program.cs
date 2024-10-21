using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }
        
        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Write your code here

                // Time Complexity: O(n)
                // Space Complexity: O(n)
                
                // Check if the input array is empty
                if (nums.Length == 0)
                {
                    // Return an empty list if there are no numbers
                    return new List<int>();
                }

                // Use a HashSet to store the numbers for quick lookup
                HashSet<int> numSet = new HashSet<int>(nums);
                
                // Initialize a list to hold the missing numbers
                IList<int> missingNumbers = new List<int>();

                // Loop through numbers from 1 to n (where n is the length of the input array)
                for (int i = 1; i <= nums.Length; i++)
                {
                    // If the current number is not in the HashSet, it is missing
                    if (!numSet.Contains(i))
                    {
                        missingNumbers.Add(i); // Add the missing number to the list
                    }
                }
                return missingNumbers;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Write your code here

                // Time Complexity: O(n)
                // Space Complexity: O(1)
                
                int left = 0; // Pointer starting from the beginning
                int right = nums.Length - 1; // Pointer starting from the end

                while (left < right)
                {
                    // If left is even, move to the next
                    if (nums[left] % 2 == 0)
                    {
                        left++;
                    }
                    // If right is odd, move to the previous
                    else if (nums[right] % 2 != 0)
                    {
                        right--;
                    }
                    // If left is odd and right is even, swap them
                    else
                    {
                        int temp = nums[left];
                        nums[left] = nums[right];
                        nums[right] = temp;
                        left++;
                        right--;
                    }
                }
                return nums;// Placeholder
            }

            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Write your code here

                // Time Complexity: O(n)
                // Space Complexity: O(n)

                // Dictionary to store the value and its index
                Dictionary<int, int> map = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    int remaining = target - nums[i]; // The number needed to reach the target

                    // If the complement exists in the map, return the indices
                    if (map.ContainsKey(remaining))
                    {
                        return new int[] { map[remaining], i };
                    }

                    // Add the number and its index to the map
                    map[nums[i]] = i;
                }

                // Return empty array if no solution is found
                return new int[0]; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Write your code here

                // Time Complexity: O(nlogn)
                // Space Complexity: O(1)

                // Edge case: The input array must have at least three numbers
                if (nums.Length < 3) throw new ArgumentException("Input array must contain at least three numbers.");

                // Sort the array to easily find the largest and smallest elements
                Array.Sort(nums);

                // The maximum product can be:
                // After sorting, the last three numbers in the array are the largest
                // Calculate the product of the three largest numbers
                int maxProduct1 = nums[nums.Length - 1] * nums[nums.Length - 2] * nums[nums.Length - 3];

                // The array may contain negative numbers.
                // Calculate the product of the largest number and the two smallest numbers
                // This is considered two negative numbers can produce a positive product
                int maxProduct2 = nums[0] * nums[1] * nums[nums.Length - 1];

                // Return the maximum of both products
                return Math.Max(maxProduct1, maxProduct2);  // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Write your code here

                // Time Complexity: O(logn)
                // Space Complexity: O(n)

                // Edge case for 0
                if (decimalNumber == 0) return "0"; 
        
                string binary = "";
                
                while (decimalNumber > 0)
                {
                    // Get the remainder when dividing by 2
                    int remainder = decimalNumber % 2;  

                    // Append the remainder to the binary string
                    binary = remainder + binary;  

                    // Divide the number by 2 to continue the conversion
                    decimalNumber /= 2;
                }
        
                return binary; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                // Write your code here

                // Time Complexity: O(logn)
                // Space Complexity: O(1)

                int left = 0;
                int right = nums.Length - 1;

                // Handle case where array is not rotated (sorted)
                if (nums[left] <= nums[right])
                {
                    return nums[left];
                }

                while (left < right)
                {
                    int mid = (left + right) / 2;

                    // If mid element is greater than the right element,
                    // the minimum element must be to the right of mid
                    if (nums[mid] > nums[right])
                    {
                        left = mid + 1;
                    }
                    // Otherwise, the minimum element is to the left (including mid)
                    else
                    {
                        right = mid;
                    }
                }

                // When left == right, we have found the smallest element
                return nums[left];; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Write your code here

                // Time Complexity: O(logn)
                // Space Complexity: O(1)

                // Negative numbers and numbers ending with 0 (except for 0 itself) can't be palindromes
                if (x < 0 || (x % 10 == 0 && x != 0)) return false;

                int reverse = 0;

                // Reverse the last half of the number
                while (x > reverse)
                {
                    // Get the last digit
                    int remainder = x % 10;  

                    // Build the reversed number
                    reverse = reverse * 10 + remainder;  

                    // Remove the last digit from the original number
                    x /= 10;  
                }

                // The number is a palindrome if the original number (or its left half) is equal to the reversed number
                // or if the original number is equal to the reversed number without the last digit (for odd length numbers)
                return x == reverse || x == reverse / 10; 
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Write your code here

                // Time Complexity: O(n)
                // Space Complexity: O(1)

                // Base case: F(0) = 0
                if (n == 0) return 0; 
                // Base case: F(1) = 1
                if (n == 1) return 1; 
                
                int first = 0; // F(0)
                int second = 1; // F(1)

                // Iteratively compute Fibonacci numbers
                for (int i = 2; i <= n; i++) {
                    int next = first + second; // F(n) = F(n-1) + F(n-2)
                    first = second; // Update first to F(n-1)
                    second = next; // Update second to F(n)
                }

                return second; // Return F(n) // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
