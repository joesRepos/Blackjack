// Initiliase and shuffle the deck.
Deck deck = new Deck();
deck.Shuffle();

// Initialise and add two cards to the player and dealers hands.
Hand playerHand = new Hand();
Hand dealerHand = new Hand();
playerHand.AddCard(deck.Draw());
playerHand.AddCard(deck.Draw());
dealerHand.AddCard(deck.Draw());
dealerHand.AddCard(deck.Draw());

// First round display.
Console.WriteLine("Welcome to Blackjack!");
Console.WriteLine("Your hand: " + playerHand);
Console.WriteLine("Dealear's shown hand: " + dealerHand.Cards[^1]);

// Loop while both can play.
while (playerHand.GetValue() < 21 && dealerHand.GetValue() < 21)
{
    Console.WriteLine("Stick or twist?");
    string input = Console.ReadLine().ToLower();

    // Exit command.
    if (input == "exit" || input == "stick")
    {
        break;
    }
    else if (input == "twist")
    {
        // Draw another hand for the player if they twsist.
        playerHand.AddCard(deck.Draw());
        // If the dealer can draw, they do.
        if (dealerHand.GetValue() < 21)
        {
            dealerHand.AddCard(deck.Draw());
        }
        Console.WriteLine("Your hand: " + playerHand);
        Console.WriteLine("Dealer shown hand: " + dealerHand.Cards[^1]);
    }
    else
    {
        // Correct player if they input an invalid command.
        Console.WriteLine("Please enter only 'stick', 'twist', or 'exit' only");
    }
}

// Player hand too large condition.
if (playerHand.GetValue() > 21)
{
    Console.WriteLine("You went over 21 and have lost.");
    Console.WriteLine("Your hand: " + playerHand);
}
// Player win condition.
else if (playerHand.GetValue() > dealerHand.GetValue() || (dealerHand.GetValue() > 21 && playerHand.GetValue() < 21))
{
    Console.WriteLine("You won!");
    Console.WriteLine("Your hand: " + playerHand);
    Console.WriteLine("Dealer's full hand: " + dealerHand);
}
// Dealer wins condtion.
else
{
    Console.WriteLine("The dealer has won, you have lost.");
    Console.WriteLine("Your hand: " + playerHand);
    Console.WriteLine("Dealer's full hand: " + dealerHand);
    Console.WriteLine("House always wins.");
}

Console.WriteLine("Game Over.");
