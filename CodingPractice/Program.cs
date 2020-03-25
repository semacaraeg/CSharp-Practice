using System;
using System.Collections.Generic;

namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // LinkedListNode<string> lln = new LinkedListNode<string>("orange");
            // // Create a new LinkedList.
            // LinkedList<string> ll = new LinkedList<string>();

            // // Add the "orange" node and display its properties.
            // ll.AddLast(lln);
            // Console.WriteLine("After adding the node to the empty LinkedList ....");

            // // Add nodes before and after the "orange" node and display the "orange" node's properties.
            // ll.AddFirst("red");
            // ll.AddLast("yellow");
            // Console.WriteLine("After adding red and yellow ....");
            //// Console.WriteLine(GetIthItemInLinkedList(ll.First, 2).Value);


            //array
            //int[] myArray = { 3, 4, 6, 10, 11, 15 };
            //int[] alicesArray = { 1, 5, 8, 12, 14, 19 };

            //// Prints [1, 3, 4, 5, 6, 8, 10, 11, 12, 14, 15, 19]

            //int[] res = MergeArrays(myArray, alicesArray);
            //foreach (int i in res) {
            //    Console.Write(i + ' ');
            //}
            // string res = Palindrome.CheckIfPalindrome("abba").ToString();
            //Console.WriteLine(res);

            char[] cArr = { 't', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e' };
            ReverseStringII.ReverseWords(cArr);
            int[,] matrix = new int[,] {
                { 1, 1, 1},
                { 1,0,1 },
                { 1,1,1 } 
            };
            
            ZeroMatrix.SetZeroes(matrix);

            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    Console.Write(matrix[i, j]);
                }
            }

        }

        //public static LinkedListNode<string> GetIthItemInLinkedList(LinkedListNode<string> head, int i)
        //{
        //    if (i < 0)
        //    {
        //        throw new ArgumentException($"i can't be negative: {i}", nameof(i));
        //    }

        //    var currentNode = head;
        //    var currentPosition = 0;

        //    while (currentNode != null)
        //    {
        //        if (currentPosition == i)
        //        {
        //            // Found it!
        //            return currentNode;
        //        }

        //        // Move on to the next node
        //        currentNode = currentNode.Next;
        //        currentPosition++;
        //    }

        //    throw new ArgumentException($"List has fewer than i + 1 ({i + 1}) nodes", nameof(head));
        //}

        //public static int[] MergeArrays(int[] myArray, int[] alicesArray)
        //{
        //    // Make an array big enough to fit the elements from both arrays
        //    var mergedArray = new int[myArray.Length + alicesArray.Length];

        //    int currentIndexAlices = 0;
        //    int currentIndexMyArray = 0;
        //    int currentIndexMerged = 0;

        //    while (currentIndexMerged < mergedArray.Length) {
        //        int firstUnmergedAlices = alicesArray[currentIndexAlices];
        //        int firstUnmergedMyArray = myArray[currentIndexMyArray];
        //        if()
        //        if (firstUnmergedMyArray < firstUnmergedAlices)
        //        {
        //            mergedArray[currentIndexMerged] = firstUnmergedMyArray;
        //            currentIndexMyArray++; ;
        //        }
        //        else {
        //            mergedArray[currentIndexMerged] = firstUnmergedAlices;
        //            currentIndexAlices++;
        //        }
        //        currentIndexMerged++;
        //    }

        //    // Eventually we'll want to return the merged array
        //    return mergedArray;
        //}
    }
}
