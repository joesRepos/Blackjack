public class Card
{
    // Stores the suit and rank of the card, with getters and setters.
    public string Suit { get; set; }
    public string Rank { get; set; }
    
    // The value of the card as an int.
    public int Value
    {
        get
        {
            if (Rank == "Jack" || Rank == "Queen" || Rank == "King")
                return 10;
            if (Rank == "Ace")
                return 11;
            return int.Parse(Rank);
        }
    }

    // Constructor.
    public Card(string suit, string rank)
    {
        Suit = suit;
        Rank = rank;
    }

    // Returns the string representation of the card.
    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }
}