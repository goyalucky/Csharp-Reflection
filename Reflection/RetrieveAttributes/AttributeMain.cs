/* Retrieve Attributes at Runtime: Create a custom attribute [Author("Author Name")].
Apply it to a class and use Reflection to retrieve and display the attribute value at
runtime. */

using System;
using System.Reflection;

namespace RetrieveAttributes{
    public class AttributeMain
    {
        public static void Execute()
        {
            Type type = typeof(Book);
            AuthorAttribute? author =
                (AuthorAttribute?)Attribute.GetCustomAttribute(
                    type,
                    typeof(AuthorAttribute)
                );
            if (author != null)
            {
                Console.WriteLine("Author Name: " + author.Name);
            }
            else
            {
                Console.WriteLine("Author attribute not found");
            }
        }
    }
}
