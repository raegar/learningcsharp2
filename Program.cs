namespace learningcsharp2;
class Program //Write a C# Sharp program to print the sum of two numbers.
{
    static void Main(string[] args)
    {
        double firstNumber = 7;
        double secondNumber = 12;
        Console.Write("Enter the first number: ");
        firstNumber = Convert.ToDouble( Console.ReadLine() );
        Console.Write("Enter the second number: ");
        secondNumber = Convert.ToDouble( Console.ReadLine() );

        Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}");
        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");

        Console.ReadKey(true);
    }
}
