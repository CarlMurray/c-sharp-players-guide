// iterates through each rank and colour and creates and prints card

foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
{
    foreach (CardColour colour in Enum.GetValues(typeof(CardColour)))
    {
        Card card = new Card(rank, colour);
        card.PrintCard();
    }
}

// card class
public class Card
{
    public CardRank Rank { get; set; }
    public CardColour Colour { get; set; }

    // constructor
    public Card(CardRank rank, CardColour colour)
    {
        Rank = rank;
        Colour = colour;
    }

    // prints card colour, rank to console
    public void PrintCard()
    {
        Console.WriteLine($"The {Colour} {Rank}");
    }

    // prints the card type to console
    public void GetCardType()
    {
        if ((int)Rank < 11)
        {
            Console.Write("Card is a number");
        }
        else Console.WriteLine("Card is a symbol");
    }
}

public enum CardRank
{
    One = 1,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Dollar,
    Percentage,
    Chevron,
    Ampersand
};

public enum CardColour
{
    Red = 1,
    Green,
    Blue,
    Yellow
}