using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace algo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello data structures exercises !");

            // Stack
            // Queue
            // Linked List
            // Hashtable

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Linked List");
            Console.WriteLine("2) Stack");
            Console.WriteLine("3) Queue");
            Console.WriteLine("4) Hashtable");
            Console.Write("\r\nSelect an option: ");
        
            switch (Console.ReadLine())
            {
                case "1":
                    ReverseString();
                    return true;
                case "2":
                    RemoveWhitespace();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        /// <summary> 
        /// Helper Method To Display The Result 
        /// </summary> 
        /// <param name="result"></param> 
        /// <param name="counter"></param> 
        public static void DisplayResult(int[] result, int counter, int arraySize)
        {
            if (result == null) return;

            Console.WriteLine("Test Case: " + result[0] + "," + result[1] + " - timecomplexity:" + (timeComplexity) + " - interactions:" + counter);

            timeComplexity = 0;

            Console.WriteLine("================================================");
        }



    }
}