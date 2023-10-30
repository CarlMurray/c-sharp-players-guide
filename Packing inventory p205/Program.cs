Pack pack = CreatePack();
AddItem(ChooseItem(), pack);

int ChooseItem()
{
    Console.WriteLine("Add an item to your pack.");
    Console.WriteLine($"1 - {new Water().ToString()}");
    Console.WriteLine($"2 - {new Food().ToString()}");
    Console.WriteLine($"3 - {new Sword().ToString()}");
    Console.WriteLine($"4 - {new Arrow().ToString()}");
    Console.WriteLine($"5 - {new Rope().ToString()}");
    Console.WriteLine($"6 - {new Bow().ToString()}");
    return Convert.ToInt32(Console.ReadLine());
}

void AddItem(int choice, Pack pack)
{
    InventoryItem item = new InventoryItem();
    switch (choice)
    {
        case 1:
            item = new Water();
            break;
        case 2:
            item = new Food();
            break;
        case 3:
            item = new Sword();
            break;
        case 4:
            item = new Arrow();
            break;
        case 5:
            item = new Rope();
            break;
        case 6:
            item = new Bow();
            break;
    }

    pack.Add(item);
    AddItem(ChooseItem(), pack);
}

Pack CreatePack()
{
    Console.WriteLine("Create a pack.");
    Console.WriteLine("Enter the pack's max item count: ");
    int itemCount = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the pack's max weight: ");
    float maxWeight = (float)Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the pack's max volume: ");
    float maxVolume = (float)Convert.ToDouble(Console.ReadLine());
    Pack pack = new Pack(itemCount, maxWeight, maxVolume);
    return pack;
}

public class InventoryItem
{
    public float Weight { get; set; }
    public float Volume { get; set; }

    public InventoryItem()
    {
        Weight = 0f;
        Volume = 0f;
    }

    public InventoryItem(float weight, float volume)
    {
        Weight = weight;
        Volume = volume;
    }

    public override string ToString()
    {
        return $"{this.GetType()}; Weight: {Weight}; Volume: {Volume}";
    }
}

public class Arrow : InventoryItem
{
    public Arrow()
    {
        Weight = 0.1f;
        Volume = 0.05f;
    }
}

public class Bow : InventoryItem
{
    public Bow()
    {
        Weight = 1;
        Volume = 4;
    }
}

public class Water : InventoryItem
{
    public Water()
    {
        Weight = 2;
        Volume = 3;
    }
}

public class Rope : InventoryItem
{
    public Rope()
    {
        Weight = 1;
        Volume = 1.5f;
    }
}

public class Food : InventoryItem
{
    public Food()
    {
        Weight = 1;
        Volume = 0.5f;
    }
}

public class Sword : InventoryItem
{
    public Sword()
    {
        Weight = 5;
        Volume = 3;
    }
}

public class Pack
{
    // Properties
    public InventoryItem[] Contents { get; set; }
    public int NumberOfItems { get; set; }
    private float MaxWeight { get; set; }
    private float MaxVolume { get; set; }
    private float PackWeight { get; set; }
    private float PackVolume { get; set; }
    private int ItemCount { get; set; }

    // Constructor
    public Pack(int numberOfItems, float maxWeight, float maxVolume)
    {
        NumberOfItems = numberOfItems;
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
        Contents = new InventoryItem[NumberOfItems];
        PackWeight = 0;
        PackVolume = 0;
        ItemCount = 0;
    }

    // Add method
    public bool Add(InventoryItem item)
    {
        if ((PackWeight + item.Weight >= MaxWeight))
        {
            Console.WriteLine($"ERROR: Max Weight is {MaxWeight}!");
            return false;
        }

        if (PackVolume + item.Volume >= MaxVolume)
        {
            Console.WriteLine($"ERROR: Max Volume is {MaxVolume}!");
            return false;
        }

        if (ItemCount >= NumberOfItems)
        {
            Console.WriteLine($"ERROR: Max items is {NumberOfItems}!");
            return false;
        }

        Contents[ItemCount] = item;
        PackWeight += item.Weight;
        PackVolume += item.Volume;
        ItemCount++;
        Console.WriteLine($"---------------");
        Console.WriteLine($"{item} added to pack!");
        Console.WriteLine($"Total weight: {PackWeight}");
        Console.WriteLine($"Total volume: {PackVolume}");
        Console.WriteLine($"Total items: {ItemCount}");
        Console.WriteLine(ToString());
        Console.WriteLine($"---------------");
        return true;
    }

    public override string ToString()
    {
        string print = "Pack containing ";

        foreach (var item in Contents)
        {
            if (item != null)
            {
                print += item.GetType() + " ";
            }
        }

        return print;
    }
}