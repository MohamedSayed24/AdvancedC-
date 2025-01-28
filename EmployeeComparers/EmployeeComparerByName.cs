using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_.EmployeeComparers
{
    public class EmployeeComparerByName : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x?.Name == y?.Name;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
           return HashCode.Combine(obj.Name);
        }
    }
}
