// See https://aka.ms/new-console-template for more information




internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("tamashi");
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("sheikvane ritskhvi: ");
            int num = int.Parse(Console.ReadLine());
            arr[i] = num;

        }
        Console.WriteLine("sheikvane indeksi: ");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine("shedegi : " + CalculateNumberSum(arr, index));

    }


    static int CalculateNumberSum(int[] arr, int index)
    {
        int n = 0;
        {
            n = arr[index];
        }

        int result = 0;

        while (true)
        {
            if (n == 0)
            {
                break;
            }
            result += n % 10;
            n /= 10;
        }
        return result;

    }
}




//static void Main(string[] args)
//{
//    Console.WriteLine("tamashi");
//    int[] arr = new int[5];

//    for (int i = 0; i < arr.Length; i++)
//    {
//        Console.WriteLine("sheikvane ritskhvi: ");
//        int num = int.Parse(Console.ReadLine());
//        arr[i] = num;  // Assign to arr[i] instead of arr[1]
//    }

//    Console.WriteLine("sheikvane indeksi: ");
//    int index = int.Parse(Console.ReadLine());

//    // Validate index
//    if (index < 0 || index >= arr.Length)
//    {
//        Console.WriteLine("Invalid index. Please enter a number between 0 and " + (arr.Length - 1));
//    }
//    else
//    {
//        Console.WriteLine("shedegi: " + CalculateNumberSum(arr, index));
//    }
//}

//static int CalculateNumberSum(int[] arr, int index)
//{
//    int n = arr[index];
//    int result = 0;

//    while (n != 0)
//    {
//        result += n % 10;
//        n /= 10;
//    }
//    return result;
//}


