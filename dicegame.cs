Console.WriteLine("Welcome to the dice game\n");
Console.WriteLine("Press 1 to ROLLLLLL\n");
decimal start = decimal.Parse(Console.ReadLine());

if(start == 1)
{
    Random dice = new Random();
    decimal roll1 = dice.Next(1,7);
    decimal roll2 = dice.Next(1,7);
    decimal roll3 = dice.Next(1,7);
    decimal total = roll1 + roll2 + roll3;

    Console.WriteLine($"First Dice: {roll1}");
    Console.WriteLine($"Second Dice: {roll2}");
    Console.WriteLine($"Third Dice: {roll3}");
    Console.WriteLine($"You rolled {total}");

    if(total > 20)
    {
        Console.WriteLine("Congratulations you win 5 Billion Dollars");
    }
    else if(total > 10)
    {
        Console.WriteLine("Congratulations you win 5 Playstation 5s");
    }
    else if(roll1 == 6 && roll2 == 6 && roll3 == 6)
    {
        Console.WriteLine("You are the Devil");
    }
    else
    {
        Console.WriteLine("You are a loser!!!");
    }
}
