using System;
using System.Collections.Generic;
using System.Text;

namespace Training.leetcode
{
    class JewelsAndStones
    {
        static void Main()
        {
            string J = "aA"; string S = "aAAbbbb";
            /*Output: "3"*/

            Console.WriteLine(NumJewelsInStones(J,S));
        }
        public static int NumJewelsInStones(string J, string S)
        {
            int counter = 0;
            for (int i = 0; i <= S.Length - 1; i++)
                if (J.Contains(S[i]))
                    counter++;
            return counter;
        }
    }
}
