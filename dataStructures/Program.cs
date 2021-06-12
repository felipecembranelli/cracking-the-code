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
            var userInput = 0;

            do
            {
                var option = MainMenu();

                switch (option)
                {
                    case 1:
                        LinkedList.Run();
                        break;
                    case 2:
                        //RemoveWhitespace();
                        break;
                    case 3:
                        break;
                    default:
                        return;
                }
            } while(userInput!=5);

           
        }

        private static int MainMenu()
        {

            Console.WriteLine("Hello data structures exercises !");

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Linked List");
            Console.WriteLine("2) Stack");
            Console.WriteLine("3) Queue");
            Console.WriteLine("4) Hashtable");
            Console.WriteLine("5) Exit");

            Console.WriteLine("\r\nSelect an option: ");

            var option = Console.ReadLine();
        
            return Convert.ToInt32(option);

            
        }

        /// <summary> 
        /// Helper Method To Display The Result 
        /// </summary> 
        /// <param name="result"></param> 
        /// <param name="counter"></param> 
        // public static void DisplayResult(int[] result, int counter, int arraySize)
        // {
        //     if (result == null) return;

        //     Console.WriteLine("Test Case: " + result[0] + "," + result[1] + " - timecomplexity:" + (timeComplexity) + " - interactions:" + counter);

        //     timeComplexity = 0;

        //     Console.WriteLine("================================================");
        // }



    }
}