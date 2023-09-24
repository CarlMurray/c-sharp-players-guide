using System.Reflection.Metadata.Ecma335;

Dog cooper = new Dog() { Age = 5, Name = "Cooper", Breed = "Golden Retriever" };
Dog lexi = new Dog() { Age = 6, Name = "Lexi", Breed = "Golden Retriever" };

Console.WriteLine($"Cooper is {cooper.Age}");
Console.WriteLine($"Cooper is a {cooper.Breed}");
cooper.ShowDetails();
cooper.Bark();

var dogs = Utilities.BreedDogs(cooper, lexi);
foreach (Dog dog in dogs)
{
    Console.WriteLine(dog.Name);
    dog.Bark();
}

public static class Utilities
{
    public static Dog[] BreedDogs(Dog male, Dog female)
    {
        Dog[] dogs = new Dog[5];
        for (int i = 0; i < 5; i++)
        {
            dogs[i] = new Dog() { Age = 0, Name = $"Puppy {i + 1}", Breed = $"{female.Breed}" };
        }

        Console.WriteLine($"{male.Name} and {female.Name} had puppies!");
        return dogs;
    }
}


public class Dog
{
    private int _age;
    private static int _minAge = 0;
    public string Name { get; init; }
    public string Breed { get; init; }

    public int Age
    {
        get => _age;
        set
        {
            if (value < _minAge)
            {
                Console.WriteLine($"Age must be greater than {_minAge}.");
            }
            else
            {
                _age = value;
            }
        }
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Name: {Name}; Age: {Age}; Breed: {Breed}");
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} says woof!");
    }
}