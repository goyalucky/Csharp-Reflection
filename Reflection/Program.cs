using System;
using System.Reflection.Metadata;
namespace Reflection;
using CalculatorReflection;
using DynamicMethodInvocation;
using ReflectionExample;
using RetrieveAttributes;
using StaticFieldReflection;
using StudentReflection;

public class Program
{
    public static void Main(string[] args)
    {
        ConfigMain.Execute();
        // AttributeMain.Execute();
        // MathMain.Execute();
        // StudentMain.Execute();
        // CalculatorMain.Execute();
        // ReflectionMain.Execute();
        // ClassInfoReflection.Execute();
    }
}