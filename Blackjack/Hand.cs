using System.Collections.Generic;
using System.Linq;

public class Hand
{
    // Array list of Card.
    public List<Card> Cards { get; } = new List<Card>();

    // Add a new card to the hand.
    public void AddCard(Card card)
    {
        Cards.Add(card);
    }

    // Get the numeric value of the hnd.
    public int GetValue()
    {
        int total = Cards.Sum(c => c.Value);

        int aceCount = Cards.Count(c => c.Rank == "Ace");

        while (total > 21 && aceCount > 0)
        {
            total -= 10;
            aceCount--;
        }

        return total;
    }

    // Returns the string representation of the hand.
    public override string ToString()
    {
        return string.Join(", ", Cards);
    }
}