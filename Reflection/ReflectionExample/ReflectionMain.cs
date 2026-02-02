/* Access Private Field: Create a class Person with a private field age. Use Reflection to
modify and retrieve its value. */

using System;
using System.Reflection;

namespace ReflectionExample{
    public class ReflectionMain
    {
        public static void Execute()
        {
            Person person = new Person();
            Type type = typeof(Person);
            FieldInfo field = type.GetField("age",BindingFlags.NonPublic|BindingFlags.Instance);
            field.SetValue(person,25);
            int ageValue = (int) field.GetValue(person);
            Console.WriteLine("Private field age value-" + ageValue);
        }
    }
}