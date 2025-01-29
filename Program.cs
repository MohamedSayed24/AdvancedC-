using System.Security.Cryptography;
using System;
using System.Collections;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace AssignmentADV01
{
    internal class Program
    {
        public static void ReverseArrayList(ArrayList list)
        {
            int start = 0;
            int end = list.Count - 1;

            while (start < end)
            {
                object temp = list[start]!;
                list[start] = list[end];
                list[end] = temp;

                start++;
                end--;
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();  

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num); 
                }
            }
            return evenNumbers;
        }


        static void Main(string[] args)
            {
            #region 1 : The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we

            //Cause in bubble sort as the elments or input of the array increase the time complexity increase as well n^2
            //This is because the algorithm requires a large number of comparisons and swaps, which leads to a slow and impractical sorting process for large datasets.
            //Nested Loops in Bubble Sort Algorithm are the main reason for the time complexity of O(n^2)
            //The outer loop runs n-1 times, and the inner loop runs n-i-1 times, where i is the current iteration of the outer loop
            //if we have 10 elements in the array the time complexity will be 10^2 = 100
            //if we have 100 elements in the array the time complexity will be 100^2 = 10000
            //if we have 1000 elements in the array the time complexity will be 1000^2 = 1000000
            //So it is not efficient for large datasets

            //============================How to Optimise the Bubble Sort Algorithm============================

            /* in normal bubble sort we always compare the adjacent elements and swap them if they are in the wrong order
             * but may be array is already sorted and we don't need to do any swap
             * otherwise the algorithm will continue to run until the end of the array n-1 times
             * so if we can add a flag to insure if the array is already sorted or not 
             * we can decrease the time complexity of the algorithm

             */

            //============================ Implementing the Optimised Bubble Sort Algorithm============================

            //int[] numbers = { 5 ,2 ,4 ,3 ,6 };
            //OptimizedSortArray.BubbleSort(numbers);

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region 2 :
            //Range<int> range = new Range<int>(1, 100);
            //bool flag = range.IsInRange(5);
            //Console.WriteLine(flag);

            //int lenght = range.Lenght();
            //Console.WriteLine(lenght);
            #endregion

            #region 3 :

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add("Mohamed");
            //arrayList.Add(10);
            //ReverseArrayList(arrayList);

            #endregion

            #region 4. You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> evenNumbers = new List<int>();
            //evenNumbers = GetEvenNumbers(numbers);

            //foreach (int item in evenNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5. implement a custom list called FixedSizeList<T> with a predetermined capacity.This list should not allow more elements than its capacity and
            //////////

            #endregion

            #region 6
            /////////////
            #endregion
        }
    }
    }
