using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitRotation
{
    class DigitRotation
    {
        public void Rotating()
        {
            try
            {
                long number, maximum = 0;
               // int count = 0;
                Console.WriteLine("Enter a number:");
                string input = Console.ReadLine();
                number = Convert.ToInt64(input);
                while (true)
                {
                    for (int index = 0; index < input.Length; index++)
                    {
                        long b = number % 10;
                        b = b * (long)Math.Pow(10, input.Length - 1);
                        long c = number / 10;
                        number = c + b;
                        //count++;
                        if (number > maximum)
                        {
                            maximum = number;
                        }
                    }
                    break;
                }
                Console.WriteLine("\nThe maximum number is {0}", maximum);
                //Console.WriteLine("\nThe number of rotations is: {0} ", count);
            }
            catch (Exception exception) {
                Console.WriteLine("{0}.\nInvlid Input.",exception.Message);
            }
            Console.WriteLine("\nDo another iteration? y/n");
            try
            {
                string input;
                input = Console.ReadLine();
                if (input == "y")
                {
                    Rotating();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
