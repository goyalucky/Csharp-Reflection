/* Get Class Information: Write a program to accept a class name as input and display
its methods, fields, and constructors using Reflection. */

using System;
using System.Reflection;

namespace Reflection{
    public class ClassInfoReflection{
        public static void Execute(){
            string className = Console.ReadLine();

            // Get type information
            Type type = Type.GetType(className);

            if (type == null){
                Console.WriteLine("Class not found!");
                return;
            }

            // Display Constructors
            Console.WriteLine("\n--- Constructors ---");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach(var ctor in constructors)
            {
                Console.WriteLine(ctor);
            }

            // Display Fields
            Console.WriteLine("\n--- Fields ---");
            FieldInfo[] fields = type.GetFields(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static
            );
            foreach (var field in fields)
            {
                Console.WriteLine(field);
            }

            // Display Methods
            Console.WriteLine("\n--- Methods ---");
            MethodInfo[] methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine(method);
            }
        }
    }
}
