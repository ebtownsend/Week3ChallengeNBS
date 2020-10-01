using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitToWord
{
    class DigitToWord
    {
        public string digitToWord(int number)
        {
            string[] units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
            string[] tens = { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};

            string words = "";

            if (number == 0)
            {
                return "zero";
            }

            if ((number / 1000) > 0) // get thousands digit
            {
                words += units[(number / 1000)] + " thousand ";
                number = number % 1000; // take off thousands, keep remainder.
            }

            if ((number / 100) > 0) // get hundreds digit
            {
                words += units[(number / 100)] + " hundred ";
                number = number % 100; // take off hundreds, keep remainder.
            }

            if (number > 0)
            {
                if(words != "")
                {
                    // if not empty, it must have hundreds value.
                    words += "and ";
                }

                if (number < 20)
                {
                    words += units[number];
                } else
                {
                    // divide by ten to get 'tens' number
                    words += tens[number / 10];

                    if ((number % 10) > 0) // modulus to get remainder
                    {
                        words += " " + units[number % 10];
                    }
                } 
            }
            return words;
        }
    }
}
