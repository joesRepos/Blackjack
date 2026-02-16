public class Card
{
    public string Suit { get; set; }
    public string Rank { get; set; }
    
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

    public Card(string suit, string rank)
    {
        Suit = suit;
        Rank = rank;
    }

    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }
}