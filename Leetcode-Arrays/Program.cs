using System;

namespace Leetcode_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = {1,1,2};

            //int[] nums = {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
            //int len = RemoveDuplicates(nums);
            //int[] prices = {7,1,5,3,6,4};
            ////int[] prices = { 1,2,3,4,5 };
            //int maxProfit = MaxProfit(prices);
            //Console.WriteLine($"Max Profit is  {maxProfit}");

            int[] origArr = { 1,2,3,4,5,6,7};
            int[] origArr2 = { -1,-100,3,99 };
            int[] rotatedArr = Rotate(origArr2, 2);
            // any modification to nums in your function would be known by the caller.
            // using the length returned by your function, it prints the first len elements.
            Console.Write("Orig: ");
            for (int i = 0; i < origArr2.Length; i++)
            {
                Console.Write($"{origArr2[i]} ");
               
                
            }
            Console.WriteLine(" -- ");
            Console.Write("Rotated: ");
            for (int i = 0; i < rotatedArr.Length; i++)
            {
               
                Console.Write($"{rotatedArr[i]} ");
            }
        }

        //    public static int RemoveDuplicates(int[] nums)
        //    {
        //        if (nums.Length == 0) return 0;
        //        int i = 0;
        //        for (int j = 1; j < nums.Length; j++)
        //        {
        //            if (nums[j] != nums[i])
        //            {
        //                i++;
        //                nums[i] = nums[j];
        //            }
        //        }
        //        return i + 1;
        //    }

        //public static int MaxProfit(int[] prices)
        //{
        //        int maxprofit = 0;
        //        for (int i = 1; i < prices.Length; i++)
        //        {
        //            if (prices[i] > prices[i - 1])
        //                maxprofit += prices[i] - prices[i - 1];
        //        }
        //        return maxprofit;
            
        //}

        public static int[] Rotate(int[] nums, int k)
        {
            int[] rotated = new int[nums.Length];
            Console.WriteLine(rotated.Length);
            int startingIndex = nums.Length - k;
            int i = 0;
            for (int j = 0; j < rotated.Length; j++) {
                if (startingIndex < rotated.Length)
                {
                    rotated[j] = nums[startingIndex];
                    startingIndex++;
                }
                else {
                    rotated[j] = nums[i];
                    i++;
                }
            }
            return rotated;
        }

    }
}