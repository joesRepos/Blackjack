Deck deck = new Deck();
deck.Shuffle();

Hand playerHand = new Hand();
Hand dealerHand = new Hand();

playerHand.AddCard(deck.Draw());
playerHand.AddCard(deck.Draw());

dealerHand.AddCard(deck.Draw());
dealerHand.AddCard(deck.Draw());

Console.WriteLine("Welcome to Blackjack!");
Console.WriteLine("Your hand: " + playerHand);
Console.WriteLine("Dealear's shows: " + dealerHand.Cards[0]);

while (playerHand.GetValue() < 21)
{
    Console.WriteLine("Stick or twist?");
    string input = Console.ReadLine().ToLower();

    if (input == "exit")
    {
        break;
    }
    else if (input == "twist")
    {
        playerHand.AddCard(deck.Draw());
        Console.WriteLine("Your hand: " + playerHand);
    }
    else if (input == "stick")
    {
        break;
    }
    else
    {
        Console.WriteLine("Please enter only 'stick', 'twist', or 'exit");
    }
}

Console.WriteLine("Game Over.");