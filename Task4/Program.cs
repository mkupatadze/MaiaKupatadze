// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("Hello, World!");

int day = 3;
if (day > 7)
    Console.WriteLine("arastsori ritskhvi");

switch (day)

{
    case 6:
        Console.WriteLine("kvira");
        break;
    case 0:
        Console.WriteLine("orshabati");
        break;
    case 1:
        Console.WriteLine("samshabati");
        break;
    case 2:
        Console.WriteLine("otkhshabati");
        break;
    case 3:
        Console.WriteLine("khutshabati");
        break;
    case 4:
        Console.WriteLine("paraskevi");
        break;
    case 5:
        Console.WriteLine("shabati");
        break;

}

int sum = 0;

while (true)
{
    Console.WriteLine("enter numbers: ");

    int num = int.Parse(Console.ReadLine());
    
    if (num <= 0)
    {
        Console.WriteLine(sum);
        break;
    }
    else
    {
        sum = sum + num;
    }
}

//int n = 10;

//while (true)
//{
//    Console.WriteLine(n - 1);
//}

//int n = 0;
//while (n < 5)
//{
//    Console.Write(n);
//    n++;
//}

int b = 5;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i * b);
}


