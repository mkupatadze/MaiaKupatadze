// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 integers:");
            int[] arr = new int[5];

            // Input numbers
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Input number {0}: ", i + 1);
                while (true)
                {
                    try
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                        break; // Exit loop if parsing is successful
                    }
                    catch (FormatException)
                    {
                        Console.Write("Invalid input. Please enter an integer: ");
                    }
                }
            }

            // Input index
            Console.Write("Enter the index (0-4) for logic calculation: ");
            int index;
            while (true)
            {
                try
                {
                    index = int.Parse(Console.ReadLine());
                    if (index < 0 || index >= arr.Length)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    break; // Exit loop if index is valid
                }
                catch (FormatException)
                {
                    Console.Write("Invalid input. Please enter an integer: ");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Write("Index out of range. Please enter a valid index (0-4): ");
                }
            }

            // Calculate and display result
            Console.WriteLine("Sum of digits: " + CalculateNumberSum(arr, index));
        }

        static int CalculateNumberSum(int[] array, int idx)
        {
            int number = array[idx];

            // Calculate the sum of the digits
            int result = 0;

            while (number != 0)
            {
                result += number % 10;
                number /= 10;
            }

            return result;
        }
    }
}
