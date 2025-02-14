using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV03
{
    public class ListMethods
    {
        public static bool Exist<T>(List<T> values, Predicate<T> match)
        {
            foreach (T value in values)
            {
                if (match(value)) return true;

            }
            return false;
        }

        public static T? Find<T>(List<T> values, Predicate<T> match)
        {
            foreach (T value in values)
            {
                if (match(value)) return value;

            }
            return default;
        }
        public static List<T> FindAll<T>(List<T> values, Predicate<T> match)
        {
            List<T> res = new List<T>();
            foreach (T value in values)
            {
                if (match(value)) res.Add(value);

            }
            return res;
        }
        public static int FindIndex<T>(List<T> values, Predicate<T> match)
        {

            for (int i = 0; i < values.Count; i++)
            {
                if (match(values[i])) return i;

            }
            return -1;
           
        }
        public static int FindLastIndex<T>(List<T> values, Predicate<T> match)
        {
            int keeper = -1;
            for (int i = 0; i < values.Count; i++)
            {
                if (match(values[i]))
                    keeper = i;

            }
            return keeper;

        }

        public static void Foreach<T>(List<T> values, Action<T> match)
        {

            for (int i = 0; i < values.Count; i++)
            {
                if (match is not null)
                    match.Invoke(values[i]);
                else
                {
                    Console.WriteLine(values[i]);
                }


            }
        }

        public static bool TrueForAll<T>(List<T> values, Predicate<T> match)
        {
            if (match is null)
                throw new ArgumentNullException("match is null");
            foreach (T value in values)
            {
                if (!match(value)) return false;
            }
            return true;


        }
    }
}

