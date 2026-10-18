// The game setup
Random random = new Random();
Console.Write("How many rounds do you want to play: ");
int roundsPlayed = int.Parse(Console.ReadLine());

List<int> totalScore = new List<int>();
Console.WriteLine($"Playing {roundsPlayed} rounds...");

// Simulating the game
for(int rounds=1; rounds<roundsPlayed; rounds++)
{
    int score = random.Next(0,101);
    totalScore.Add(score);
    Console.WriteLine($"Round {rounds}: You earned {score} points");
}
Console.WriteLine($"Total Score Logged: {totalScore.Count}");

// Building the top 5 leaderboard
totalScore.Sort();
totalScore.Reverse();
int[] topScores = new int[5];
for(int i = 0;i<topScores.Length;i++)
{
    topScores[i] = totalScore[i];
}

// Printing the leaderboard
Console.WriteLine("\n");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("TOP 5 SCORES");
Console.WriteLine("------------------------------------------------------");
for(int j = 0;j<topScores.Length;j++)
{
    Console.WriteLine($"{j+1}. {topScores[j]} points");
    
}  
Console.WriteLine("------------------------------------------------------\n");

// Displaying the lowest point
int lowestScore = topScores[0];
for(int k=0;k<totalScore.Count;k++) // totalScore is a list and to calculate the length of a list we use .Count not .Length
{
    if(totalScore[k]<lowestScore)
    {
        lowestScore = totalScore[k];
    }   
}

Console.WriteLine($"The Lowest Recorded Score is: {lowestScore}");