
using System;
using System.Collections;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AssignmentADV02

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Given an array consists of numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than X.
            //Console.WriteLine("Enter The Size of Array");
            //int size;
            //bool Flag = int.TryParse(Console.ReadLine(), out size);
            //Console.WriteLine("Enter The Number of Queries");
            //int numOfQuereis;
            //bool NumberOfQuereis = int.TryParse(Console.ReadLine(), out numOfQuereis);
            //int[] array = new int[size];
            //Console.WriteLine("Enter The Elements Of The Array");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out array[i]);
            //}

            //for (int i = 0; i < numOfQuereis; i++)
            //{

            //    Console.WriteLine("Enter The Value");
            //    int.TryParse(Console.ReadLine(), out int value);
            //    int count = 0;
            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        if (array[j] > value)
            //        {
            //            count++;
            //        }

            //    }
            //    Console.WriteLine($"There is  {count} numbers is  greater than {value}");
            //}

            #endregion

            #region 2. Given a number N and an array of N numbers. Determine if it's palindrome or not.
            //Console.WriteLine("Enter The Number Of Elements in Array");
            //bool flag = int.TryParse(Console.ReadLine(), out int size);
            //int[] numbers = new int[size];
            //Console.WriteLine("Enter The Elements Of The Array");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out numbers[i]);
            //}

            //for (int i = 0;i< numbers.Length/2;i++)
            //{

            //    if (numbers[i] != numbers[numbers.Length - 1 - i])
            //    {
            //        Console.WriteLine("The Array is Not Palindrome");
            //        return;
            //    }

            //}

            //Console.WriteLine("The Array is Palindrome");
            #endregion

            #region 3. Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue = ReverseQueue(queue);

            //foreach (int item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.


            //string str = "([])";
            //Stack<char> stack = new Stack<char>();
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == '(' || str[i]=='[' || str[i]=='{')
            //        stack.Push(str[i]);

            //    if (str[i] == ')' || str[i] == ']' || str[i] == '}')
            //    {


            //        if (stack.Count > 0 &&

            //            (stack.Peek() == '(' && str[i] == ')'

            //            || stack.Peek() == '{' && str[i] == '}'

            //            || stack.Peek() == '[' && str[i] == ']'

            //            )

            //            )
            //        {
            //            stack.Pop();
            //        }

            //    }
            //    //else
            //    //{
            //    //    Console.WriteLine("Not Balanced");
            //    //    break;
            //    //}
            //}
            //Console.WriteLine(stack.Count>0 ? "Not Balanced" : " Balanced");



            #endregion

            #region 5. Given an array, implement a function to remove duplicate elements from an array.

            //int[] numbers = new int[] {1,2,3,3,4,4,5,5,6};
            //int[] result = RemoveDuplicates(numbers);
            //Console.WriteLine(string.Join(", ", result));
            #endregion

            #region 6. Given an array list , implement a function to remove all odd numbers from it.

            //ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if ((int)list[i] % 2 != 0)
            //    {
            //        list.RemoveAt(i);

            //    }
            //}
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 7. Implement a queue that can hold different data types.  And insert the following data: queue.Enqueue(1) queue.Enqueue(“Apple”) queue.Enqueue(5.28)

            //Queue<object> queue = new Queue<object>();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);
            #endregion

            #region 8. Create a function that pushes a series of integers onto a stack. Then,search for a target integer in the stack.If the target is found, print a message indicating that the target was found how many elements were checked before finding the target(“Target was found successfully and the count = 5”).If the target is not found, print a message indicating that the target was not found(“Target was not found”).
            //Console.WriteLine("Enter The Target");
            //int target;
            //bool flag = int.TryParse(Console.ReadLine(), out target);
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //stack.Push(6);
            //stack.Push(7);
            //stack.Push(8);
            //stack.Push(9);

            //Stack<int> tempStack = new Stack<int>(stack);
            //int count = 0;
            //bool isFound = false;
            //while (stack.Count > 0)
            //{
            //    count++;
            //    int item = stack.Pop();
            //    tempStack.Push(item);

            //    if (item == target)
            //    {
            //        isFound = true;
            //        break;
            //    }

            //}
            //for (int i = 0; i < tempStack.Count; i++)
            //{
            //    stack.Push(tempStack.Pop());
            //}
            //if (isFound)
            //{
            //    Console.WriteLine($"Target was found successfully and the count = {count}");
            //}
            //else
            //{
            //    Console.WriteLine("Target was not found");
            //}
            #endregion

            #region 9. Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.

            int[] arr1 = new int[] { 1, 2, 3, 4, 4 };
            int[] arr2 = new int[] { 10, 4, 4 };
            List<int> intersection = new List<int>();
            Dictionary<int, int> numbersDictionary = new Dictionary<int, int>();

            
            //foreach (int num in arr1)
            //{
            //    if (numbersDictionary.ContainsKey(num))
            //        numbersDictionary[num]++;
            //    else
            //        numbersDictionary[num] = 1;
            //}

            
            foreach (int num in arr2)
            {
                if (numbersDictionary.ContainsKey(num) && numbersDictionary[num] > 0)
                {
                    intersection.Add(num);
                    numbersDictionary[num]--; 
                }
            }

            // Print the result
            Console.WriteLine("Intersection: " + string.Join(", ", intersection));
        
            #endregion
        }
        private static Queue<int> ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>(queue);
            return new Queue<int>(stack);
        }

        static int[] RemoveDuplicates(int[] arr)
        {
            HashSet<int> uniqueElements = new HashSet<int>(arr);
            return new List<int>(uniqueElements).ToArray();
        }
    }
}

    
        
       
    