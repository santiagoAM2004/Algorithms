using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            {
                Console.WriteLine(test(new[] { 5, 5, 5, 5, 5 }));
                Console.WriteLine(test(new[] { 3, 3, 3, 3 }));
                Console.WriteLine(test(new[] { 3, 3, 3, 5, 5, 5 }));
                Console.WriteLine(test(new[] { 1, 6, 8, 10 }));
            }
                static bool test(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 3 && nums[i] != 5) return false;
            }
            return true;
        }
        }
    }
}
