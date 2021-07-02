using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SpecialNumber
{
    public class Program
    {
        /// <summary>
        /// Special Number
        /// Special Number is list of non-negative integer that is constructed from non-negative integer
        /// Special Number has two operations, Special Summation and Special Multiplication
        /// 
        /// You must implement SpecialSummation and Special Multiplication Method
        /// See explanation for each method below
        /// 
        /// DO NOT CHANGE THE CODE IN MAIN
        /// </summary>
        static void Main(string[] args)
        {
            TestResult(6, SpecialSummation(123));
            TestResult(9, SpecialSummation(567));

            TestResult(6, SpecialMultiplication(123));
            TestResult(0, SpecialMultiplication(567));

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        /**
         * PLEASE DO NOT CHANGE THE CODE OF THIS METHODO
         **/
        private static void TestResult(int expected, int actual)
        {
            if (expected == actual)
            {
                Console.WriteLine("Answer is correct");
            }
            else
            {
                Console.WriteLine("Answer is wrong. Expected level is {0} but your result is {1}", expected, actual);
            }
        }

        /// <summary>
        /// SpecialSummation is sums of all digit in Special Number
        /// Example:
        /// >>> SpecialSummation(123)
        /// >>> 6   (from 1+2+3)
        /// 
        /// >>> SpecialSummation(567)
        /// >>> 9   (from 5+6+7 = 18 then 1+8 = 9)
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Summation of Special Number</returns>
        public static int SpecialSummation(int number)
        {
            // AMEND YOUR CODE BELOW THIS LINE
            try
            {
                if (number != 0)
                {
                    return (number % 10 + SpecialSummation(number / 10));
                }
                else
                {
                    return 0;
                }
            }
            catch (NotFiniteNumberException ex)
            {
                throw new NotImplementedException("Special Summation Error occured", ex);
            }
            // AMEND YOUR CODE ABOVE THIS LINE
        }

        /// <summary>
        /// SpecialMultiplication is multiplication of all digit in Special Number
        /// Example:
        /// >>> SpecialMultiplication(123)
        /// >>> 6   (from 1*2*3)
        /// 
        /// >>> SpecialSummation(567)
        /// >>> 0   (from 5*6*7 = 210 then 2*1*0 = 0)
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Multiplication of Special Number</returns>
        public static int SpecialMultiplication(int number)
        {
            // AMEND YOUR CODE BELOW THIS LINE
            try
            {
                if (number != 0)
                {
                    return ((number % 10) * SpecialMultiplication(number / 10));
                }
                else
                {
                    return 1;
                }
            }
            catch (NotFiniteNumberException ex)
            {
                throw new NotImplementedException("Special Summation Error occured", ex);
            }
            // AMEND YOUR CODE ABOVE THIS LINE
        }

    }
}