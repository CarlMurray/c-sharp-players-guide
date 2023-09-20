CreateArrow();

void CreateArrow()
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
}

class Arrow
{
    public ArrowHead _arrowHead;
    public Fletching _fletching;
    public float _length;

    public Arrow(ArrowHead arrowHead, Fletching fletching, float length)
    {
        _arrowHead = arrowHead;
        _fletching = fletching;
        _length = length;
    }

    public void PrintArrow()
    {
        Console.WriteLine($"{_arrowHead}, {_fletching}, {_length}");
    }

    public string GetCost()
    {
        float totalCost = 0;
        float arrowHeadCost = 0;
        float fletchingCost = 0;
        float lengthCost = 0;

        switch (_arrowHead)
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

        switch (_fletching)
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

        lengthCost = (_length) * (float)0.05;

        totalCost = arrowHeadCost + fletchingCost + lengthCost;
        return $"Total cost is {totalCost} gold.";
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