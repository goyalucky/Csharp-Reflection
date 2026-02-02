/* Dynamically Create Objects: Write a program to create an instance of a Student class
dynamically using Reflection without using the new keyword. */

using System;
using System.Dynamic;
using System.Reflection;
namespace StudentReflection
{
    public class StudentMain
    {
        public static void Execute()
        {
            Type type = typeof(Student);
            object? obj = Activator.CreateInstance(type);
            if(obj == null)
            {
                Console.WriteLine("object creation failed");
                return;
            }
            // set the value using reflection
            type.GetProperty("Name")?.SetValue(obj,"Lucky");
            type.GetProperty("Age")?.SetValue(obj,21);

            // call a method using reflection
            MethodInfo? method = type.GetMethod("Display");
            method?.Invoke(obj,null);
        }
    }
}