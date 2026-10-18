using billing;

Console.Write("Enter the subTotal: ");
double st = double.Parse(Console.ReadLine());

double tax = Calculator.calculateTax(st);
double total = Calculator.calculateTotal(st,tax);

Console.WriteLine($"Subtotal: {st:C}");
Console.WriteLine($"Tax: {tax:C}");
Console.WriteLine($"Total: {total:C}");
