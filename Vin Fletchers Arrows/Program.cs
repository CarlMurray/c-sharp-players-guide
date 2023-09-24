CreateArrow();

void CreateArrow()
{
    Console.WriteLine("Which type of arrow do you want to make?");
    Console.WriteLine("1: Elite Arrow");
    Console.WriteLine("2: Beginner Arrow");
    Console.WriteLine("3: Marksman Arrow");
    Console.WriteLine("4: Custom Arrow");
    int choice = Convert.ToInt32(Console.ReadLine());

    Arrow arrow;
    switch (choice)
    {
        case 1:
            arrow = Arrow.CreateEliteArrow();
            Console.WriteLine(arrow.GetCost());
            break;
        case 2:
            arrow = Arrow.CreateBeginnerArrow();
            Console.WriteLine(arrow.GetCost());
            break;
        case 3:
            arrow = Arrow.CreateMarksmanArrow();
            Console.WriteLine(arrow.GetCost());
            break;
        case 4:
            arrow = Arrow.CreateCustomArrow();
            Console.WriteLine(arrow.GetCost());
            break;
    }
}

class Arrow
{
    public ArrowHead ArrowHead { get; }
    public Fletching Fletching { get; }
    public float Length { get; }

    // CONCTRUCTOR
    public Arrow(ArrowHead arrowHead, Fletching fletching, float length)
    {
        ArrowHead = arrowHead;
        Fletching = fletching;
        Length = length;
    }

    public void PrintArrow()
    {
        Console.WriteLine($"{ArrowHead}, {Fletching}, {Length}");
    }

    public string GetCost()
    {
        float totalCost = 0;
        float arrowHeadCost = 0;
        float fletchingCost = 0;
        float lengthCost = 0;

        switch (ArrowHead)
        {
            case ArrowHead.Steel:
                arrowHeadCost = 10;
                break;
            case ArrowHead.Wood:
                arrowHeadCost = 3;
                break;
            case ArrowHead.Obsidian:
                arrowHeadCost = 5;
                break;
        }

        switch (Fletching)
        {
            case Fletching.Plastic:
                fletchingCost = 10;
                break;
            case Fletching.TurkeyFeathers:
                fletchingCost = 5;
                break;
            case Fletching.GooseFeathers:
                fletchingCost = 3;
                break;
        }

        lengthCost = (Length) * (float)0.05;

        totalCost = arrowHeadCost + fletchingCost + lengthCost;
        return $"Total cost is {totalCost} gold.";
    }

    public static Arrow CreateEliteArrow()
    {
        return new Arrow(arrowHead: ArrowHead.Steel, fletching: Fletching.Plastic, length: 95);
    }

    public static Arrow CreateBeginnerArrow()
    {
        return new Arrow(arrowHead: ArrowHead.Wood, fletching: Fletching.GooseFeathers, length: 75);
    }

    public static Arrow CreateMarksmanArrow()
    {
        return new Arrow(arrowHead: ArrowHead.Steel, fletching: Fletching.GooseFeathers, length: 65);
    }

    public static Arrow CreateCustomArrow()
    {
        // GET ARROW HEAD
        Console.WriteLine("Pick an arrow head type:");
        Console.WriteLine("1: Steel");
        Console.WriteLine("2: Wood");
        Console.WriteLine("3: Obsidian");

        ArrowHead arrowHead;
        do
        {
            arrowHead = (ArrowHead)(Convert.ToInt32(Console.ReadLine()) - 1);
        } while ((int)arrowHead < 0 || (int)arrowHead > 2);

        // GET FLETCHING TYPE
        Console.WriteLine("Pick a fletching material:");
        Console.WriteLine("1: Plastic");
        Console.WriteLine("2: Turkey Feathers");
        Console.WriteLine("3: Goose Feathers");
        Fletching fletching;
        do
        {
            fletching = (Fletching)(Convert.ToInt32(Console.ReadLine()) - 1);
        } while ((int)fletching < 0 || (int)fletching > 2);

        // GET LENGTH
        Console.WriteLine("Enter a length between 60 - 100cm");
        int length;
        do
        {
            length = Convert.ToInt32(Console.ReadLine());
        } while (length < 60 || length > 100);

        Arrow arrow = new Arrow(arrowHead, fletching, length);

        // GET COST
        Console.WriteLine(arrow.GetCost());
        return arrow;
    }
}

enum ArrowHead
{
    Steel,
    Wood,
    Obsidian
}

enum Fletching
{
    Plastic,
    TurkeyFeathers,
    GooseFeathers
}