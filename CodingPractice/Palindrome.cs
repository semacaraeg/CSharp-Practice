using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    public static class Palindrome
    {
        public static bool CheckIfPalindrome(string input){
            char[] inputCharArr = input.ToCharArray();
            int start = 0;
            int end = inputCharArr.Length - 1;
            
            while (start < end) {
                if (inputCharArr[start] != inputCharArr[end]){
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}
