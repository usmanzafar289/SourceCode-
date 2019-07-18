using System;
using System.Linq;

namespace OddOccurrencesInArray
{  
class program
    {

        public static void Main()
        {
            int[] A = new int[8];
            A[0] = 9;  A[1] = 3; A[2] = 9;
            A[3] = 3;  A[4] = 9;  A[5] = 7;
            A[6] = 9;

            var oddAccurence = Solution.solution(A);
            Console.WriteLine("OddOccurrencesInArray: {0}", oddAccurence);
            Console.ReadLine();
        }
    }


    public static class Solution
    {
        public static int solution(int[] A)
        {
            return A.Aggregate((x, y) => x ^ y);
        }
    }
    
 }
