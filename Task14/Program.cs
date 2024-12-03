internal class Program
{
    public class MyException : Exception
    {
        public int Status { get; }
        public MyException(string message, int ststus) : base(message)
        {
            Status = Status;
        }
    }
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the first number: ");
            double firstNumber = GetValidNumber();
            Console.WriteLine("Enter the second number: ");
            double secondNumber = GetValidNumber();
            Console.Write("Enter the operation (+, -, *, /): ");
            char operation = GetValidOperation();
            double result = PerformCalculation(firstNumber, secondNumber, operation);
            Console.WriteLine($"The result is: {result}");
        }
        catch (MyException ex)
        {
            Console.WriteLine($"Custom Error: {ex.Message} (Status: {ex.Status})"); ;
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
    static double GetValidNumber()
    {
        while (true)
        {
            try
            {
                string input = Console.ReadLine();
                return double.Parse(input);
            }
            catch (FormatException)
            {
                Console.Write("Invalid input! Please enter a valid number: ");
            }
        }
    }
    static char GetValidOperation()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input.Length == 1 && "+-*/".Contains(input))
                return input[0];
            throw new MyException("Invalid operation entered. Please use +, -, *, or /.", 400);
        }
    }
    static double PerformCalculation(double firstNumber, double secondNumber, char operation)
    {
        try
        {
            switch (operation)
            {
                case '+':
                    return firstNumber + secondNumber;
                case '-':
                    return firstNumber - secondNumber;
                case '*':
                    return firstNumber * secondNumber;
                case '/':
                    if (secondNumber == 0)
                        throw new DivideByZeroException("Cannot divide by zero!");
                    return firstNumber / secondNumber;
                default:
                    throw new InvalidOperationException("Invalid operation.");
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}
