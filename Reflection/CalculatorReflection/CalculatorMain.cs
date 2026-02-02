/* Invoke Private Method: Define a class Calculator with a private method Multiply(int a, int b). Use Reflection to invoke this 
method and display the result. */

using System;
using System.Reflection;

namespace CalculatorReflection{
    public class CalculatorMain{
        public static void Execute()
        {
            Calculator calc = new Calculator();
            Type type = typeof(Calculator);

            MethodInfo? method = type.GetMethod(
                "Multiply",
                BindingFlags.NonPublic | BindingFlags.Instance
            );

            if (method == null)
            {
                Console.WriteLine("method not found");
                return;
            }

            object? result = method.Invoke(calc, new object[] { 5, 4 });

            if(result != null)
            {
                Console.WriteLine("Multiply result " + result);
            }
        }
    }
}
