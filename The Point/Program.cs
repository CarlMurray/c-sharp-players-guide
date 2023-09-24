Point point1 = new Point(2,3);
Point point2 = new Point(-4,0);

Console.WriteLine(point1.PrintPoint());
Console.WriteLine(point2.PrintPoint());

public class Point
{
    //Defines X, Y properties
    public float X { get; set; }
    public float Y { get; set; }

    //Constructor
    public Point()
    {
        X = 0;
        Y = 0;
    }

    //Constructor with arguments
    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }

    //Prints point formatted
    public string PrintPoint()
    {
        return ($"({X}, {Y})");
    }
}