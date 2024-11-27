using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public interface IAnimal
    {
        string MakeSound();
    }

    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public abstract string MakeSound();
    }

    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override string MakeSound()
        {
            return "Woof";
        }
    }

    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override string MakeSound()
        {
            return "Meow";
        }
    }

    public class Cow : Animal
    {
        public Cow(string name, int age) : base(name, age)
        {
        }

        public override string MakeSound()
        {
            return "Moo";
        }
    }
}
