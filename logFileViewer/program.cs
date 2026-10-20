// Initializing the variables
string logFile = "log.txt";
string timeStamp = DateTime.Now.ToString("HH:mm:ss");
Console.WriteLine("\nEnter your Message: ");
string msg = Console.ReadLine();

// Logging a new event0
File.AppendAllText(logFile, $"[{timeStamp}] Application Started - Your Message: '{msg}' \n");
Console.WriteLine("Event Logged.\n");

// Reading back the event log history
Console.WriteLine("Event History\n");
using StreamReader reader = new StreamReader(logFile);
string line;

while((line = reader.ReadLine()) != null)
{
    Console.WriteLine(line);
}

// Counting the logged events
string []allLines = File.ReadAllLines(logFile);
Console.WriteLine($"\nTotal Events Logged: {allLines.Length}");