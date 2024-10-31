// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");

//int[] numbers = { 1, 2, 3, 4 };

//Console.WriteLine(numbers[3]);



//pirveli davaleba
string[] student = { "Maia", "Naia", "Nino" };

Console.WriteLine(student[0]);
Console.WriteLine(student[1]);
Console.WriteLine(student[2]);



//meore davaleba 
int[,] grades = new int[3, 2] { { 99, 88 }, {97, 85 }, {95, 89} };
string[] students = { "Maia", "Naia", "Nino" };

for (int i = 0; i < grades.GetLength(0); i++)
{
    Console.Write(students[i] + ": ");
    for (int j = 0; j < grades.GetLength(1); j++)
    {
        Console.WriteLine(grades[i, j] + (j < grades.GetLength(1) - 1 ? ", " : ""));

    }
    Console.WriteLine();
}
