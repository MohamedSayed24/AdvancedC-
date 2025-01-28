using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_.EmployeeComparers
{
    public class EmployeeIComparerId : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x?.Id.CompareTo(y?.Id ?? 0) is null ? 0 : 1;
        }

    }
}
