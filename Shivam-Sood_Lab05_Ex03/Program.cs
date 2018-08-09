using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shivam_Sood_Lab05_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Student> lnkStudent = new LinkedList<Student>();

            Console.WriteLine("==================================================================================================");
            Console.WriteLine("COMP212-M18 Lab05 Exercise #3");
            Console.WriteLine("==================================================================================================");

            Console.WriteLine("Creating empty LinkedList<Student> container.");
            PrintLinkedList(lnkStudent);
            Student[] students = new Student[]
            {
                new Student(),
                new Student(89, "Shirley"),
                new Student(01, "Loki"),
                new Student(18, "Ashleen"),
                new Student(20, "Irene"),
                new Student(23, "Kevin")
            };
            Console.WriteLine("Adding 6 students to the LinkedList");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            for (int i = 0; i < students.Length; i++)
            {
                AddLinkedListItem(lnkStudent, students[i]);
            }
            PrintLinkedList(lnkStudent);

            Console.WriteLine("Removing a student from the LinkedList");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            RemoveLinkedListItem(lnkStudent, students[3]);
            PrintLinkedList(lnkStudent);

            Console.WriteLine("Searching for a student in the LinkedList");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Student foundStudent = SearchLinkedListItem(lnkStudent, students[2]).Value;
            Console.Write($"The student with '{students[2]}' is ");
            if (foundStudent == null)
                Console.Write(" not ");
            Console.WriteLine("found in the LinkedList.");
            if (SearchLinkedListItem(lnkStudent, new Student(22, "Michelle")) != null)
            {
                foundStudent = SearchLinkedListItem(lnkStudent, new Student(22, "Michelle")).Value;
            }
            else
            {
                foundStudent = null;
            }
            Console.Write($"The student with 'ID: 33 Name: Michelle' is ");
            if (foundStudent == null)
                Console.Write(" not ");
            Console.WriteLine("found in the LinkedList.");
            Console.WriteLine();

            Console.WriteLine("Clearing the linked list");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            RemoveAllLinkedListItems(lnkStudent);
            PrintLinkedList(lnkStudent);

        }
        private static void AddLinkedListItem(LinkedList<Student> name, Student @object)
        {
            name.AddLast(@object);
        }
        private static void RemoveLinkedListItem(LinkedList<Student> name, Student @object)
        {
            name.Remove(@object);
        }
        private static void PrintLinkedList(LinkedList<Student> name)
        {

            if (name.First == null)
            {
                Console.WriteLine("Empty list");
            }
            else
            {
                foreach (Student item in name)
                {
                    Console.WriteLine($"{item} ");
                }
            }
            Console.WriteLine();
        }
        //Searching - returns the first node that contains 'obj'
        private static LinkedListNode<Student> SearchLinkedListItem(LinkedList<Student> name, Student @object)
        {
            return name.Find(@object);
        }

        //Clearing the linked list
        private static void RemoveAllLinkedListItems(LinkedList<Student> name)
        {
            name.Clear();
        }
    }
}
