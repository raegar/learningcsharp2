﻿namespace learningcsharp2;
class Program //Write a C# Sharp program to print the sum of two numbers.
{
    static void Main(string[] args)
    {
        int firstNumber = 7;
        int secondNumber = 12;

        Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}");
        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");

        Console.ReadKey(true);
    }
}
