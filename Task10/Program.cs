using Task10;

class Program
{

    static void Main()
    {
        Fraction a = new Fraction(1, 2);
        Fraction b = new Fraction(2, 3);

        Fraction sum = a + b;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine(a == b);
        Console.WriteLine(a != b);
    }

}



