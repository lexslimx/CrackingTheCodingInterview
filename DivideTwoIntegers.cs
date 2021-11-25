using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {
            /*
              Keep subtracting the dividend from the divisor until dividend becomes less than divisor.
              The dividend becomes the remainder, and the number of times subtraction is done becomes the quotient       
              3,10
              3,7,1
              3,4,2,
              3,1,3,
              3,-2,-   3
              
             */

            // Calculate sign of divisor i.e.,
            // sign will be negative only iff
            // either one of them is negative
            // otherwise it will be positive
            int sign = ((dividend < 0) ^
                    (divisor < 0)) ? -1 : 1;

            // Update both divisor and
            // dividend positive
            dividend = Math.Abs(dividend);
            divisor = Math.Abs(divisor);

            // Initialize the quotient
            int quotient = 0;

            while (dividend >= divisor)
            {
                dividend -= divisor;
                ++quotient;
            }

            //if the sign value computed earlier is -1 then negate the value of quotient
            if (sign == -1) quotient = -quotient;
            return quotient;
        }
    }
}
