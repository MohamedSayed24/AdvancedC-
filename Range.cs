using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV01
{
    public class Range<T> where T :  IComparable<T>
    {
        public T? Min { get; set; }
        public T? Max { get; set; }

        public Range(T? min, T? max)
        {
            Min = min;
            Max = max;
        }

        public bool IsInRange(T? value)
        {
            return Min?.CompareTo(value) <= 0 && Max?.CompareTo(value) >= 0;

        }

        public int Lenght()
        {
            int count = 0;
            bool IsDone = false;
            for (int i = 0; i.CompareTo(Max) <0; i++)
            {
                IsDone = true;
                if (IsDone)
                    count++;

            }
            return count-1;


        }
    }
}
