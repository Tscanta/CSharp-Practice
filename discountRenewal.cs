// Generating a random number
Random days = new Random();
decimal daysUntilExpiration = days.Next(7);
decimal discount = 0;

// Conditions
if(daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired");
}
else if(daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription ends within a day. Please renew ASAP");
    discount = 20;
}
else
{
    Console.WriteLine($"Your subscription expires within {daysUntilExpiration} days");
    discount = 10;
}

if(discount > 0 )
{
    Console.WriteLine($"Renew Now and save upto {discount}% off");
}