Colour primary = Colour.White;
Console.WriteLine(primary.PrintColour());

Colour secondary = new Colour(133, 190, 10);
Console.WriteLine(secondary.PrintColour());

public class Colour
{
    //Properties
    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }

    //Constructor
    public Colour()
    {
        R = 0;
        G = 0;
        B = 0;
    }

    //Constructor
    public Colour(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
    }

    //Prints colour formatted
    public string PrintColour()
    {
        return ($"rgb({R}, {G}, {B})");
    }

    //Define static colours
    public static Colour White { get; } = new Colour(255, 255, 255);
    public static Colour Yellow { get; } = new Colour(255, 255, 0);
    public static Colour Green { get; } = new Colour(0, 128, 0);
    public static Colour Blue { get; } = new Colour(0, 0, 255);
    public static Colour Purple { get; } = new Colour(128, 0, 128);
}