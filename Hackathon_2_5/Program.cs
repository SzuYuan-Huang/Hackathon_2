using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome palindrome = new Palindrome();
            Console.WriteLine("請輸入字：");
            string text = Console.ReadLine();
            if (text == palindrome.isPalindrome(text))
            {
                Console.WriteLine("是回文");
            }
            else
            {
                Console.WriteLine("不是回文");
            }
            Console.ReadLine();
        }
    }
}
