using CalculatorLibrary;
using System;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        int a = 10;
        int b = 5;

        int resAdd = calculator.Add(a, b);
        int resSubtract = calculator.Subtract(a, b);
        int resMultiply = calculator.Multiply(a, b);

        Console.WriteLine($"a = {a} , b = {b}");
        Console.WriteLine($"Addition of {a} and {b}: {resAdd}");
        Console.WriteLine($"Subtraction of {a} and {b}: {resSubtract}");
        Console.WriteLine($"Multiplication of {a} and {b}: {resMultiply}");

        
        try
        {
            int resDivide = calculator.Divide(a, b);
            Console.WriteLine($"Division of {a} by {b}: {resDivide}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Division by zero error: {ex.Message}");
        }

        Console.ReadLine(); 
    }
}
