using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorTest2.Models
{
    public class SimpleCalculator : ISimpleCalculator
    {
        //Add two given numbers
        public int Add(int start, int amount)
        {
            return start + amount;
        }

        //Divide two given numbers
        public int Divide(int start, int by)
        {
            return start / by;
        }

        //multiply two given numbers
        public int Multiply(int start, int by)
        {
            return start * by;
        }

        // subtract two given numbers
        public int Subtract(int start, int amount)
        {
            return start - amount;
        }

        //Claculate nth prime number
        public void GetPrimeNumber(int number)
        {
            int num = 1;
            int count = 0;
            while (true)
            {
                num++;
                if (IsPrime(num))
                {
                    count++;
                }
                if (count == number)
                {
                    Console.WriteLine(number + "th prime number is " + num);
                    break;
                }
            }
            Console.ReadKey();
        }
        public static bool IsPrime(int number)
        {
            int counter = 0;
            for (int j = 2; j < number; j++)
            {
                if (number % j == 0)
                {
                    counter = 1;
                    break;
                }
            }
            if (counter == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}