using System;
using System.Collections.Generic;

public class Deck
{
    private List<Card> cards = new List<Card>();
    private Random random = new Random();

    // Constructor.
    public Deck()
    {
        // All possible suits and ranks.
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] ranks = 
        { 
            "2", "3", "4", "5", "6", "7", "8", "9", "10",
            "Jack", "Queen", "King", "Ace"
        };

        // Constructs the deck unshuffled.
        foreach (var suit in suits)
        {
            foreach (var rank in ranks)
            {
                cards.Add(new Card(suit, rank));
            }
        }
    }

    // Shuffle the deck.
    public void Shuffle()
    {
        for (int i = 0; i < cards.Count; i++)
        {
            int j = random.Next(cards.Count);
            (cards[i], cards[j]) = (cards[j], cards[i]);
        }
    }

    // Draw a card from the deck.
    public Card Draw()
    {
        Card topCard = cards[0];
        cards.RemoveAt(0);
        return topCard;
    }
}