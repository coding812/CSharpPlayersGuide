Console.Title = "The Card";
Console.Clear();


static void DisplayDeck()
{
    foreach (CardColor color in Enum.GetValues(typeof(CardColor)))
    {
        foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
        {
            Card card = new Card(color, rank);
            Console.WriteLine($"{card.Name} is a {(card.IsFaceCard ? "Face" : "Number")} card");
        }
    }
}

DisplayDeck();



class Card
{
    public CardColor Color { get; set; }
    public CardRank Rank { get; set; }
    public string Name { get; set; }

    public Card(CardColor color, CardRank rank)
    {
        Color = color;
        Rank = rank;
        Name = $"The {Color} {Rank}";
    }
    // Incase I forget how this works later, I remembered on page 136 of the book,
    // the author mentioned that enumerations have integers assigned to them depending on their location
    // so I can compare themto each other. So since I created the enumeration in a way that the face cards
    // are greater than the number cards, I can use that to determine if a card is a face card
    public bool IsFaceCard => Rank >= CardRank.Dollar;
    public bool IsNumberCard => !IsFaceCard;

}


enum CardColor{ Red, Green, Blue, Yellow }
enum CardRank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Caret, Ampersand }

