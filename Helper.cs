using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_
{
    public class Helper<T> where T : class 
    {
        public static void Swap(ref T A , ref T B)
        {
            
            T Temp = A;
            A = B;
            B = Temp;

        }

        //public static void Swap(ref double A, ref double B)
        //{
        //    Console.WriteLine("============Swap============");
        //    double Temp = A;
        //    A = B;
        //    B = Temp;

        //}

        //public static void Swap(ref Point A, ref Point B)
        //{
        //    Console.WriteLine("============Swap============");
        //    Point Temp = A;
        //    A = B;
        //    B = Temp;

        //}

        //public static int SearchArray(T[] arr, T value , IEqualityComparer<T> equalityComparer)
        //{
        //  for (int i = 0; i < arr?.Length; i++)
        //  {
        //        if (equalityComparer!.Equals(value ,arr[i]))
        //            return i;
            
        //  } 

        //    return -1;
        //}

        public static void SortArray(T[] arr , IComparer<T> comparer) 
        {
            if (arr == null || arr.Length == 0)
                return;
            for (int i = 0; i < arr?.Length; i++)
            {
              for(int j =0; j < arr.Length-1-i; j++)
                {
                    if (comparer.Compare( arr[j], arr[j + 1]) == 1)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            
            }
                

        }

    }
}

