﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace CSharp_new_features
{
    class NullContitionalOperators
    {
        public static void NullPropgationFeature(Student student)
        {
            // Previously in C# 5
            if (student != null)
            {
                WriteLine(student.Name);
                if (student.Courses != null)
                {
                    foreach (var course in student.Courses)
                    {
                        WriteLine(course.Id);
                    }
                }
            }

            //In C# 6
            WriteLine(student?.Name);
            if (student.Courses != null)
            {
                foreach (var course in student.Courses)
                {
                    WriteLine(course.Id);
                }
            }

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