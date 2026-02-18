using System.Collections.Generic;
using System.Linq;

public class Hand
{
    public List<Card> Cards { get; } = new List<Card>();

    public void AddCard(Card card)
    {
        Cards.Add(card);
    }

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

    public override string ToString()
    {
        return string.Join(", ", Cards);
    }
}