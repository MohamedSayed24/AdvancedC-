using AdvancedC_.EmployeeComparers;

namespace AdvancedC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int A = 10, B = 20;
            //Console.WriteLine($"A = {A} , B = {B}");
            //Helper<int>.Swap(ref A, ref B);
            //Console.WriteLine($"A = {A} , B = {B}");

            //decimal A = 1.2m, B = 20.8m;
            //Console.WriteLine($"A = {A} , B = {B}");
            ////Type Safety
            //Helper.Swap(ref A, ref B);
            //Console.WriteLine($"A = {A} , B = {B}");

            //Point A = new Point(1, 2), B = new Point(5, 6);
            //Console.WriteLine($"A = {A} , B = {B}");
            //Helper.Swap(ref A, ref B);
            //Console.WriteLine($"A = {A} , B = {B}");

            //int[] numbers = { 9,6, 3, 4, 5, 8, 7, 6, 1 };
            ////int index = Helper.SearchArray(numbers, 5);
            ////Console.WriteLine(index);
            //Helper<int>.SortArray(numbers);
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Point point01 = new Point();
            //Point point02 = new Point();

            //if(point01 == point02)
            //    Console.WriteLine();

            Employee[] employees =
            {
                    new Employee(){ Id = 4, Name = "Ahmed", Salary = 2000 },
                    new Employee(){ Id = 2, Name = "Mohamed", Salary = 15000 },
                    new Employee(){ Id = 1, Name = "Aya", Salary = 9000 }
            };

            Helper<Employee>.SortArray(employees , new EmployeeIComparerId());
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            //int index = Helper<Employee>.SearchArray(employees, new Employee { Id = 2, Name = "Ahmed", Salary = 10000 }, new EmployeeComparerById());
            //Console.WriteLine(index);

            //int inde = Helper<Employee>.SearchArray(employees, new Employee { Id = 1, Name = "Mohamed", Salary = 15000 }, new EmployeeComparerByName());
            //Console.WriteLine(inde);

            //if(employees[0].CompareTo(10)
            //     Console.WriteLine("Not Found"); ;
        }
    }
}

