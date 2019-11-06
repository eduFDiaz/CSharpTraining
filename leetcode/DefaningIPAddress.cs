using System;
using System.Collections.Generic;
using System.Text;

namespace Training.leetcode
{
    class DefaningIPAddress
    {
        static void Main()
        {
            string address = "1.1.1.1";
            /*Output: "1[.]1[.]1[.]1"*/
           
            Console.WriteLine(DefangIPaddr(address));
        }
        static string DefangIPaddr(string address)
        {
            address = address.Replace(".", "[.]");
            return address;
        }
    }
}
