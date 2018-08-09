using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shivam_Sood_Lab06_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, Employee> employeesDictionary = new SortedDictionary<int, Employee>();

            Console.WriteLine("==================================================================================================");
            Console.WriteLine("COMP212-M18 Lab05 Exercise #4");
            Console.WriteLine("==================================================================================================");

            Console.WriteLine("Creating empty SortedDictionary container");
            PrintDictionary(employeesDictionary);
            Employee[] employees = new Employee[]
           {
                new Employee("Bob",12345.12),
                new Employee("Alicia",34511.88),
                new Employee("Susan",50000),
                new Employee("Paul",1000000),
                new Employee("Christiano",5213211.95),
                new Employee("Roberto",25321.44)
           };
            Console.WriteLine("Adding 6 employees to the SortedDictionary");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            for (int i = 0; i < employees.Length; i++)
            {
                AddDictionaryItem(employeesDictionary, employees[i]);
            }
            Console.WriteLine("The SortedDictionary now contains:\n");
            PrintDictionary(employeesDictionary);

            Console.WriteLine($"Removing an employee from the SortedDictionary - {employees[0]}");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            RemoveDictionaryItem(employeesDictionary, employees[0]);
            Console.WriteLine("The SortedDictionary now contains:\n");
            PrintDictionary(employeesDictionary);

            Console.WriteLine($"Searching for an employee in the SortedDictionary - with employee ID of #4");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.Write("The employee with employee Id of #4 was ");
            if (SearchDictionaryItem(employeesDictionary, 4) == null)
            {
                Console.Write("not ");
            }
            Console.WriteLine("found in the sorted dictionary.");
            Console.WriteLine();

            Console.WriteLine($"Searching for an employee in the SortedDictionary - with employee ID of #12");
            Console.Write("The employee with employee Id of #12 was ");
            if (SearchDictionaryItem(employeesDictionary, 12) == null)
            {
                Console.Write("not ");
            }
            Console.WriteLine("found in the sorted dictionary.");
            Console.WriteLine();

            Console.WriteLine("Finding Employee with highest salary in this sorted dictionary.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine($"The employee with the highest salary is: {MaxDictionaryItem(employeesDictionary)}");
            Console.WriteLine();
        }

        private static void AddDictionaryItem(SortedDictionary<int,Employee> var,Employee emp)
        {
            var.Add(emp.Id,emp);
        }

        private static void RemoveDictionaryItem(SortedDictionary<int,Employee> var,Employee emp)
        {
            var.Remove(emp.Id);
        }
        private static Employee SearchDictionaryItem(SortedDictionary<int,Employee> var,int EmpId)
        {
            return var.ContainsKey(EmpId)?var[EmpId]:null;
        }

        private static Employee MaxDictionaryItem(SortedDictionary<int,Employee> var)
        {
            Employee highestPaidEmployee = new Employee("Who", 0);
            foreach (var key in var.Keys)
            {
                if (var[key].Salary > highestPaidEmployee.Salary)
                    highestPaidEmployee = var[key];
            }
            return highestPaidEmployee;
        }
        private static void PrintDictionary(SortedDictionary<int,Employee> var)
        {
            if(var.Count==0)
            {
                Console.WriteLine("Empty SortedDictionary");
            }
            else
            {
                foreach(var item in var.Values)
                {
                    Console.WriteLine($"{item.ToString()}");
                }
            }
            Console.WriteLine();
        }
    }
}
