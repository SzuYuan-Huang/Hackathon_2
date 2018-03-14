using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hackathon_2_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_2_5.Tests
{
    [TestClass()]
    public class PalindromeTests
    {
        [TestMethod()]
        public void isPalindromeTest()
        {
            string expected = "abba";
            Palindrome palindrome = new Palindrome();
            string actual = palindrome.isPalindrome(expected);
            Assert.AreEqual(expected, actual);
        }
    }
}