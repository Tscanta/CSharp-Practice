// Creating a random secret number
Random secret = new Random();
decimal secretNumber = secret.Next(1,100);
decimal guessCount = 0;
bool hasWon = false;
decimal guess;

// Menu Display
Console.WriteLine("Welcome to the guessing game");
Console.WriteLine("Try to guess the number GOOD LUCK!");

// loop Logic
while(guessCount < 20)
{
    Console.WriteLine("Enter your guess");
    guess = decimal.Parse(Console.ReadLine());
    guessCount++;

    if(guess == secretNumber)
    {
        hasWon = true;
        break;
    }
    else if(guess < secretNumber)
    {
        Console.WriteLine("Too Low");
    }
    else if(guess > secretNumber)
    {
        Console.WriteLine("Too High");
    }
}
if(hasWon)
{
    Console.WriteLine($"You got it in {guessCount} tries");
}
else
{
    Console.WriteLine("Sorry you have ran out of tries");
}


