Deck deck = new Deck();
deck.Shuffle();

Hand playerHand = new Hand();
Hand dealerHand = new Hand();

Console.WriteLine("Welcome to Blackjack!");

while (playerHand.GetValue() < 21)
{
    Console.WriteLine("Stick or twist?");
    string input = Console.ReadLine().ToLower();

    if (input == "EXIT")
    {
        break;
    }
}

Console.WriteLine("Game Over.");