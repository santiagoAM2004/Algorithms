using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> mylist = test(new List<int>(new int[] { 1, 2, 3 , 4 }));                  
           foreach(var i in mylist)
            {
               Console.Write(i.ToString()+" ");
            }     
        }                  
        public static List<int> test(List<int> nums)
          {
            IEnumerable<int> doubled = nums.Select(x => x *= 3);
            return doubled.ToList<int>();
        }
    }
}

