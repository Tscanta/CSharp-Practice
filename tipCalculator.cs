 // Collect the bill amount and tip percentage
 decimal billAmount = 45.50m;
 decimal tipPercentage = 18.0m;

 // Display the entered values
 Console.WriteLine("Bill details:");
 Console.WriteLine($"  Bill amount:    ${billAmount}");
 Console.WriteLine($"  Tip percentage: {tipPercentage}%");

 // Calculate the tip and total
decimal tipAmount = billAmount + (tipPercentage/100);
decimal totalAmount = billAmount + tipAmount;

 // Display the results
Console.WriteLine($"\nTip Amount: ${tipAmount}");
 Console.WriteLine($"Total amount: ${totalAmount}");

