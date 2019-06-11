using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning_LINQ
{
    class BasicQuery
    {
        static void Main(string[] args)
        {
            // creates and fills a list with Student objects
            List<Student> students = new List<Student>();
            TestData.FillList(students);

            // creates a query that returns all Student objects whose Major is "Music"
            IEnumerable<Student> majorQuery =
                from stu in students
                where stu.Major == "Music"
                select stu;

            // prints out the console the Student objects returned by the query
            foreach (Student s in majorQuery)
            {
                Console.WriteLine("Name: {0}, Major: {1}", s.Name, s.Major);
            }
        }
    }

    // The TestData class contains a method that fills a list with data
    class TestData
    {
        // The FillList method adds Student objects to a list
        public static void FillList(List<Student> list)
        {
            list.Add(new Student("Charlie", "Music"));
            list.Add(new Student("Katie", "Political Science"));
            list.Add(new Student("Friday", "Math"));
            list.Add(new Student("Victoria", "Science"));
            list.Add(new Student("Rebecca", "Music"));
        }
    }

    // The Student class represents student data for students at a university
    class Student
    {
        public string Name { get; set; }
        public string Major { get; set; }

        // constructor
        public Student(string name, string major)
        {
            Name = name;
            Major = major;
        }
    }
}
