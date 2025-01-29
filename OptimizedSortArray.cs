using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV01
{
    public class OptimizedSortArray
    {
        public static void BubbleSort(int[] arr)
        {
             if (arr == null || arr.Length==0)
                return;
             bool swapped = true;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0;j<arr.Length-1-i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {    
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = false;
                    }

                }

                if (swapped) return;
                            
            }

        }
    }
}
