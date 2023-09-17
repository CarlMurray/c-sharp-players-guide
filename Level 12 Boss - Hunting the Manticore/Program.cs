var manticoreHealth = 10;
var cityHealth = 15;
var roundNumber = 1;

int manticoreDistance = ChooseManticoreDistance();

PlayRound(roundNumber);

int ChooseManticoreDistance()
{
    int distance;
    do
    {
        Console.WriteLine("How far away from the city do you want to station the Manticore?");
        distance = Convert.ToInt32(Console.ReadLine());
    } while (distance < 1 || distance > 100);

    Console.Clear();
    return distance;
}

void PlayRound(int roundNumber)
{
    Console.WriteLine($"Round {roundNumber} | City: {cityHealth}/15 | Manticore: {manticoreHealth}/10");
    int damage = CalculateCannonDamage(roundNumber);
    Console.WriteLine($"The cannon will deal {damage} damage this round.");
    int range = GetRange();

    if (FireCannon(range))
    {
        manticoreHealth -= damage;
    }

    if (manticoreHealth > 0 && cityHealth > 1)
    {
        cityHealth--;
        PlayRound(roundNumber + 1);
    }
    else if (manticoreHealth < 1 && cityHealth > 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The CITY won the game!");
        Console.ResetColor();
        return;
    }
    else if (manticoreHealth > 0 && cityHealth < 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The MANTICORE won the game!");
        Console.ResetColor();
        return;
    }
}

int CalculateCannonDamage(int roundNumber)
{
    int damage;
    if (roundNumber % 3 == 0 && roundNumber % 5 == 0)
    {
        damage = 10;
    }
    else if (roundNumber % 3 == 0 || roundNumber % 5 == 0)
    {
        damage = 3;
    }
    else damage = 1;

    return damage;
}

int GetRange()
{
    Console.Write("Enter desired cannon range:");
    int range = Convert.ToInt32(Console.ReadLine());
    return range;
}

bool FireCannon(int range)
{
    if (range < manticoreDistance)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That round FELL SHORT of the target!");
        Console.ResetColor();
    }
    else if (range == manticoreDistance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("That round HIT the target!");
        Console.ResetColor();
        return true;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That round OVER SHOT the target!");
        Console.ResetColor();
    }

    return false;
}