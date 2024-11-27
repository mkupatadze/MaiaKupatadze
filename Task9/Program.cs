
using Task9;

class Program
{
    static void Main (string[] args)
    {
        IAnimal[] animals = new IAnimal[]
        {
            new Dog("Gray", 2),
            new Cat("Bobo", 1),
            new Cow("Turfa", 5),
        };

        foreach (var animal in animals)
        {
            Console.WriteLine($"{animal.GetType().Name} says: {animal.MakeSound()}");
        }
    }
}
