/* Access and Modify Static Fields: Create a Configuration class with a private static
field API_KEY. Use Reflection to modify its value and print it. */


using System;
using System.Reflection;

namespace StaticFieldReflection
{
    public class ConfigMain
    {
        public static void Execute()
        {
            Type type = typeof(Configuration);

            FieldInfo? field = type.GetField(
                "API_KEY",
                BindingFlags.NonPublic | BindingFlags.Static
            );

            if (field == null)
            {
                Console.WriteLine("Field not found");
                return;
            }

            // modify static field
            field.SetValue(null, "NEW_SECRET_API_KEY");

            // retrieve static field
            object? value = field.GetValue(null);

            Console.WriteLine("API_KEY value: " + value);
        }
    }
}
