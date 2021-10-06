using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenDigitFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Fibonacci sequence is defined by the recurrence relation:

            // Fn = Fn−1 + Fn−2, where F1 = 1, F2 = 1, F3 = 2, .... and F12 = 144.F12 is the first term to contain three digits.

            //What is the index of the first term in the Fibonacci sequence to contain 10 digits ?

            //variables to hold the first number, second number, next number
            int firstNumber = 0, secondNumber = 1, nextNumber;
            //we start with assigning next number 0
            nextNumber = 0;
            //loop through the nextnumber as long as it is below 10 digits
            for (int i = 0; nextNumber.ToString().Length <= 10; i++)
            {
                //check to see if 10 digits in length
                if (nextNumber.ToString().Length == 10)
                {
                    //we found it so writ it out
                    Console.WriteLine($"\nSTOP FOUND IT: F{i} = {nextNumber} CONTAINS 10 DIGITS");
                    //now break out of the for loop
                    break;
                }
                else
                {
                    //write each one in sequence
                    Console.WriteLine($"F{i} = {nextNumber}");
                }
                                
                //take the firstnumber and add it to the secondnumber
                firstNumber = secondNumber;
                //take the nextnumber stored and start it as the secondnumber
                secondNumber = nextNumber;
                //now take the firstnumber updated above and add it to the second number updated above to get our next number
                nextNumber = firstNumber + secondNumber;
            }            
        }
    }
}
