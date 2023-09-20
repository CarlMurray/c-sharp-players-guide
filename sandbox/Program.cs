using System.Reflection.Metadata.Ecma335;

Dog cooper = new Dog(2, "Cooper", "Golden Retriever");
Dog lexi = new Dog(3, "Lexi", "Golden Retriever");

Dog[] dogs = { cooper, lexi };

for (int i = 0; i < dogs.Length; i++)
{
    dogs[i].ShowDetails();
    dogs[i].Bark();
}

class Dog
{
    public int _age = 0;
    public string _name = "Puppy";
    public string _breed = "Unknown";

    public Dog(int age, string name, string breed)
    {
        _age = age;
        _name = name;
        _breed = breed;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Name: {_name}; Age: {_age}; Breed: {_breed}");
    }

    public void Bark()
    {
        Console.WriteLine($"{_name} says woof!");
    }
}