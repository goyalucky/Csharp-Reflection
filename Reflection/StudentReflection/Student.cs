using System;

namespace StudentReflection
{
    public class Student
    {
        public string Name{get;set;}
        public int Age{get;set;}
        public Student()
        {
            Name = "Unknown";
            Age = 0;
        }
        public void Display()
        {
            Console.WriteLine($"Name-{Name},Age-{Age}");
        }
    }
}