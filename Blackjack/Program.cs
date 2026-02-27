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

while (playerHand.GetValue() < 21 && dealerHand.GetValue() < 21)
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
        if (dealerHand.GetValue() < 21)
        {
            dealerHand.AddCard(deck.Draw());
        }
        Console.WriteLine("Your hand: " + playerHand);
        Console.WriteLine("Dealer hand: " + dealerHand);
    }
    else if (input == "stick")
    {
        break;
    }
    else
    {
        Console.WriteLine("Please enter only 'stick', 'twist', or 'exit' only");
    }
}

if (playerHand.GetValue() > 21)
{
    Console.WriteLine("You went over 21");
    Console.WriteLine("Your hand: " + playerHand);
}
else if (playerHand.GetValue() > dealerHand.GetValue() || (dealerHand.GetValue() > 21 && playerHand.GetValue() < 21))
{
    Console.WriteLine("You won!");
    Console.WriteLine("Your hand: " + playerHand);
    Console.WriteLine("Dealer hand: " + dealerHand);
}
else
{
    Console.WriteLine("The dealer has won.");
    Console.WriteLine("Your hand: " + playerHand);
    Console.WriteLine("Dealer hand: " + dealerHand);
}

Console.WriteLine("Game Over.");
