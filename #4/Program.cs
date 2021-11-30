using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritms
{
    public class Program
    {       
        public static void Main(string[] args)
        {         
           List<string> mylist = test(new List<string>(new string[] { "Abc", "cdef", "js" , "php" }));                  
           foreach(var i in mylist)
            {
               Console.Write(i.ToString()+" ");
            }     
        }                  
        public static List<string> test(List<string> str)
        {
            IEnumerable<string> s = str.Select(x => x.ToUpper());
            return s.ToList();
        }    
    } 
}
