using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_2_5
{
    public class Palindrome
    {
        public string isPalindrome(string text)
        {
            char[] temp = text.ToCharArray();
            Array.Reverse(temp);
            string compare = new string(temp);
            return compare;
        }
    }
}
