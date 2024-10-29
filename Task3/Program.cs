// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");


Random random = new Random();
int randomNumber = random.Next(1, 10);


int Number = int.Parse(Console.ReadLine());

if (Number == randomNumber)
{
    Console.WriteLine("You win");
}
else
{
    randomNumber = random.Next(1, 10);
    

    Console.WriteLine("Try Again");
    Number = int.Parse(Console.ReadLine());

    if (Number == randomNumber)
    {
        Console.WriteLine("You win");
    }
    else
    {
        randomNumber = random.Next(1, 10);
        
        Console.WriteLine("Try Again");
        Number = int.Parse(Console.ReadLine());

        if (Number == randomNumber)
        {
            Console.WriteLine("You win");
        }
        else
        {
            Console.WriteLine("You lose");
        }
    }

}





//string text = Console.ReadLine();

//bool t = true;
//bool r = 5 > 2;
//Console.WriteLine(r);

//Console.WriteLine("hello, " + text);

//int input = int.Parse(Console.ReadLine());

//bool result = input > 5;

//Console.WriteLine(result);

//int input1 = int.Parse(Console.ReadLine());
//int input2 = int.Parse(Console.ReadLine());

//bool result = !(input1 >3 && input2 >10);
//Console.WriteLine(result);

