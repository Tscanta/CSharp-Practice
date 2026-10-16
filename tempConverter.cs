// Get the temp in fahrenheit
Console.WriteLine("Enter the temperature in fahrenheit");
decimal fahrenheit = decimal.Parse(Console.ReadLine());

// Convert the temperature to celsius
decimal celsius = (fahrenheit - 32m) * 5m / 9m;

// Display it
Console.WriteLine($"Temperature in Celsius: {celsius}");