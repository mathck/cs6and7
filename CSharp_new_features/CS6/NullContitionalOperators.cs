using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace CSharp_new_features
{
    class NullContitionalOperators
    {
        void oldWay()
        {
            var students = new List<Student>();

            if (students != null)
            {
                int length = students.Count;
                Student first = students[0];
            }

            if (students != null)
            {
                if (students[0] != null)
                {
                    if (students[0].Courses != null)
                    {
                        int courseCount = students[0].Courses.Count;
                    }
                }
            }
        }

        void smaple()
        {
            var students = new List<Student>();

            int? length = students?.Count;        // null if customers is null
            Student first = students?[0];         // null if customers is null

            int count = students?.Count ?? 0;    // 0 if customers is null

            int? courseCount = students?[0].Courses?.Count;
        }
    }

    public class Student
    {
        public string Name { get; set; }

        public IList<Course> Courses { get; set; }
    }

    public class Course
    {
        public int Id { get; set; }
    }
}
