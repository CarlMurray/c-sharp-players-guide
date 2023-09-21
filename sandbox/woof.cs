using System.Reflection.Metadata.Ecma335;

Dog cooper = new Dog(2, "Cooper", "Golden Retriever");
Dog lexi = new Dog(3, "Lexi", "Golden Retriever");

Dog[] dogs = { cooper, lexi };

for (int i = 0; i < dogs.Length; i++)
{
    dogs[i].ShowDetails();
    dogs[i].Bark();
}

cooper.SetAge(5);
Console.WriteLine($"{cooper.GetName()} turned {cooper.GetAge()}");

class Dog
{
    private int _age = 0;
    private string _name = "Puppy";
    private string _breed = "Unknown";

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

    public void SetAge(int age)
    {
        _age = age;
    } 

    public int GetAge() => _age;
    public string GetBreed() => _breed;
    public string GetName() => _name;
}