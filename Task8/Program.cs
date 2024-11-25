// See https://aka.ms/new-console-template for more information
using Task8;


internal class Program
{
    static void Main()
    {
        Person person1 = new Person("Maia", 34);

        ChangePerson(person1);

        Console.WriteLine(person1.Age + " " + person1.Name);
    }
    static void ChangePerson(Person p)
    {
        p.Age++;
        p.Name = "Temo";
    }
}