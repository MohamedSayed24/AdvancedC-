using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_
{
    public class Employee 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public Employee()
        {
            
        }

        //public int CompareTo(object? obj)
        //{
            //if (obj == null)
            //    return 1;
            //Employee employee = obj as Employee;
            //if (employee == null)
            //    return -1;
            //return Salary.CompareTo(employee.Salary);

        //    if (obj is Employee employee)
        //    {
        //        if (employee == null)
        //            return -1;
        //        return Salary.CompareTo(employee.Salary);
        //    }
        //    return -1;
        //}

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            Employee employee = obj as Employee;
            if (employee == null)
                return false;
            return Id.Equals(employee.Id) && Name!.Equals(employee.Name) && Salary.Equals(employee.Salary);
        }

        //public bool Equals(Employee? other)
        //{
        //    if (other == null)
        //        return false;
        //    return Id.Equals(other.Id) && Name!.Equals(other.Name) && Salary.Equals(other.Salary);
        //}

        public override string ToString()
        {
            return $"Id = {this.Id} , Name = {this.Name} , Salary = {this.Salary :c}";
        }

        //public int CompareTo(Employee? other)
        //{
        //    return Salary.CompareTo(other?.Salary);
        //}


        //public int CompareTo(Employee? other)
        //{
        //    return Salary.CompareTo(other?.Salary);
        //}
        //public int Compare(Employee? x, Employee? y)
        //{
        //    return x?.Salary.CompareTo(y?.Salary ?? 0) is null ? 0 : -1;
        //}

    }
}
