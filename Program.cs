/*
    Author: Jesse Schmitt
    Date: 2/5/2020
    Comments: This is my C# console program to demonstrate arrays
  
 */

using System;

namespace Deliverable3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 25; // Identifies size of the array
            int number = 1; // Begins Array at the value of 1
            int[] numbersArray = new int[SIZE]; // creats array

            // Buils loop for array
            for (int index = 0; index < SIZE; index++)
            {
                numbersArray[index] = number;  // Sets value for this index in array
               // displays "Element Value" and current vale of array
                Console.WriteLine("Element value = " + numbersArray[index].ToString()); 
                number++; // Inceases value by 1

            }
        }
    }
}
