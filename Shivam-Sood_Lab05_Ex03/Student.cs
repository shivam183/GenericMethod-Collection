using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shivam_Sood_Lab05_Ex03
{
    class Student
    {
        //public properties
        public int ID { get; set; }
        public string Name { get; set; }

        //default constructor
        public Student() : this(0, "no-name") { }

        //constructor which takes arguments
        public Student(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        //overriding ToString
        public override string ToString()
        {
            return $"ID: {this.ID}\tName: {this.Name}";
        }
    }
}
