// Programmer: David Uldrich
// Date: 02/06/2020
// Project: D3_Arrays
// Description: Build and display an array

using System;

namespace D3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiate Try-Catch to validate user input
            try
            {
                const int SIZE = 25; // Constant for array size
                int arrayNumber = 1; // Variable for array values
                int[] numbersArray = new int[SIZE]; // Create array called numbersArray

                // Initiate for loop to automatically build numbersArray
                for (int index = 0; index < SIZE; index++)
                {
                    // Set array value
                    numbersArray[index] = arrayNumber;
                    // Display array value in message
                    Console.WriteLine("Element value = " + numbersArray[index].ToString());
                    // Increment array value for next loop iteration
                    arrayNumber++;
                }
            }
            catch
            {
                // Display error message if program fails
                Console.WriteLine("A fatal error has occured. Press any key to close the program...");
            }
        }
    }
}
