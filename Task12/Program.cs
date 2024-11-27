

using Task12;

public class Program
{
    public static void Main(string[] args)
    {
        
        Box<int> intBox = new Box<int>();
        intBox.SetValue(17);
        Console.WriteLine($"Box<int> value: {intBox.GetValue()}");
        

        Box<string> stringBox = new Box<string>();
        stringBox.SetValue("Gamarjoba");
        Console.WriteLine($"Box<string> value: {stringBox.GetValue()}");

        
        List<int> intList = new List<int> {3, 7, 13 };
        Console.WriteLine($"List<int> count: {Utility.GetListCount(intList)}");

       
        List<string> stringList = new List<string> { "n", "d", "e", "a", "m"};
        Console.WriteLine($"List<string> count: {Utility.GetListCount(stringList)}");
    }
}

