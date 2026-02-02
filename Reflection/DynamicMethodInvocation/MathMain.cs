/* Dynamic Method Invocation: Define a class MathOperations with multiple public
methods (Add, Subtract, Multiply). Use Reflection to dynamically call any method
based on user input. */

using System;
using System.Reflection;

namespace DynamicMethodInvocation
{
    public class MathMain
    {
        public static void Execute()
        {
            MathOperations math = new MathOperations();
            Type type = typeof(MathOperations);

            string? methodName = Console.ReadLine();

            MethodInfo? method = type.GetMethod(methodName ?? "");

            if (method == null)
            {
                Console.WriteLine("Method not found");
                return;
            }

            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine()!);

            Console.Write("Enter second number ");
            int b = int.Parse(Console.ReadLine()!);

            object? result = method.Invoke(math, new object[] { a, b });

            Console.WriteLine("Result- " + result);
        }
    }
}