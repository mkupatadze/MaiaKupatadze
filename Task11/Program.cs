using Task11;

class Program
{
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("pirveli obieqti");
    //    Counter counter = new Counter();
    //    Console.WriteLine($"count1: {Counter.GetCount()}");


    //    Console.WriteLine("meore obieqti");
    //    Counter counter2 = new Counter();
    //    Console.WriteLine($"count2: {Counter.GetCount()}");

    //    Console.WriteLine("Reset Count:");
    //    Counter.ResetCount();
    //    Console.WriteLine($"Countebis raodenoba resetis shemded: {Counter.GetCount()}");

    //}


    static void Main(string[] args)
    {
        Console.WriteLine($"Add: {MathHelper.Add(1, 2)}");
        Console.WriteLine($"Subtract: {MathHelper.Subtract(2, 3)}");
        Console.WriteLine($"Multiply: {MathHelper.Multiply(3, 4)}");
        Console.WriteLine($"iyofa 0-ze: {MathHelper.Divide(4, 2)}");
        Console.WriteLine($"ar iyofa 0-ze: {MathHelper.Divide(5, 0)}");

    }

}