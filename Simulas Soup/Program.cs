MakeSoup();

void MakeSoup()
{
    Console.WriteLine("Pick a type:");
    Console.WriteLine("1 - Soup");
    Console.WriteLine("2 - Stew");
    Console.WriteLine("3 - Gumbo");
    int choice = Convert.ToInt32(Console.ReadLine());
    FoodType type;
    switch (choice)
    {
        case 1:
            type = FoodType.Soup;
            break;
        case 2:
            type = FoodType.Stew;
            break;
        case 3:
            type = FoodType.Gumbo;
            break;
        default:
            type = (FoodType)0;
            break;
    }

    Console.WriteLine("Pick an ingredient:");
    Console.WriteLine("1 - Mushrooms");
    Console.WriteLine("2 - Chicken");
    Console.WriteLine("3 - Carrots");
    Console.WriteLine("4 - Potatoes");
    choice = Convert.ToInt32(Console.ReadLine());
    Ingredient ingredient;
    switch (choice)
    {
        case 1:
            ingredient = Ingredient.Mushrooms;
            break;
        case 2:
            ingredient = Ingredient.Chicken;
            break;
        case 3:
            ingredient = Ingredient.Carrots;
            break;
        case 4:
            ingredient = Ingredient.Potatoes;
            break;
        default:
            ingredient = (Ingredient)0;
            break;
    }

    Console.WriteLine("Pick a seasoning:");
    Console.WriteLine("1 - Spicy");
    Console.WriteLine("2 - Salty");
    Console.WriteLine("3 - Sweet");
    choice = Convert.ToInt32(Console.ReadLine());
    Seasoning seasoning;
    switch (choice)
    {
        case 1:
            seasoning = Seasoning.Spicy;
            break;
        case 2:
            seasoning = Seasoning.Salty;
            break;
        case 3:
            seasoning = Seasoning.Sweet;
            break;
        default:
            seasoning = (Seasoning)0;
            break;
    }

    (FoodType, Ingredient, Seasoning) soup = (type, ingredient, seasoning);
    Console.WriteLine($"{seasoning} {ingredient} {type}");
}

enum FoodType
{
    Soup,
    Stew,
    Gumbo
}

enum Ingredient
{
    Mushrooms,
    Chicken,
    Carrots,
    Potatoes
}

enum Seasoning
{
    Spicy,
    Salty,
    Sweet
}