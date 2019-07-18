using System;
using System.Linq;

namespace BinaryGap
{
    class program
    {
        /* Driver program to test above functions. Ideally 
     this function should be in a separate user class. 
     It is kept here to keep code compact */
        public static void Main()
        {
          var computedValue = Solution.CalculateLargestBinaryGap(1041);
            Console.WriteLine("CalculatedLargestBinaryGap: {0}", computedValue);
            Console.ReadLine();
        }
    }

    public static class Solution
    {
        public static int CalculateLargestBinaryGap(int value)
        {
            return Convert
                    // convert to binary
                    .ToString(value, 2)
                    // remove leading and trailing 0s, as per requirement
                    .Trim('0')
                    // split the string by 1s
                    .Split(new[] { '1' })
                    // find the length of longest segment
                    .Max(x => x.Length);
        }

    }

}
