using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] inputArray = { 8, 3, 9, 11, 2 };

            // get user input
            Console.Write("Please provide the numbers to be sorted separated by space: ");

            //string inputValues = Regex.Replace(Console.ReadLine(), "[A-Za-z]", "");
            //Console.WriteLine("THIS IS INPUT: " + inputValues);
           
           string inputValues = Console.ReadLine();
         
            string[] inputStringArr = inputValues.Split(' ');


            //todo
            int[] inputArray = new int[inputStringArr.Length];

            try {

                if (inputStringArr.Length > 0 )
                {
                    inputArray = Array.ConvertAll(inputStringArr, int.Parse);
                }

                Console.Write("Values to be sorted: ");
                PrintArray(inputArray);
                //call bubble sort
                BubbleSort(inputArray);

                //call reverse bubble sort
                ReverseBubbleSort(inputArray);
            }
            catch (Exception e) {
                Console.Write("Please provide input again! ");   
                //to do yet  get user input again
            }

          
        }

        static void BubbleSort(int[] inputArr)
        {
            int temp = 0;
            for (int i = 1; i <= inputArr.Length -1; i++)
            {
                for (int j = 0; j < inputArr.Length - 1; j++)
                {
                    if (inputArr[j + 1] < inputArr[j]) {
                        temp = inputArr[j];
                        inputArr[j] = inputArr[j + 1];
                        inputArr[j + 1] = temp;
                    }
                }
            }
            Console.Write($"\n Sorted values: ");
            PrintArray(inputArr);
        }
        static void ReverseBubbleSort(int[] inputArr)
        {
            int temp = 0;
            for (int i = 1; i <= inputArr.Length - 1; i++)
            {
                for (int j = 0; j < inputArr.Length - 1; j++)
                {
                    if (inputArr[j + 1] > inputArr[j])
                    {
                        temp = inputArr[j];
                        inputArr[j] = inputArr[j + 1];
                        inputArr[j + 1] = temp;
                    }
                }
            }
            Console.Write($"\n Sorted values in Descending: ");
            PrintArray(inputArr);
        }

        static void PrintArray(int[] inputArr) {

            foreach (var item in inputArr)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();

        }
    }
}
