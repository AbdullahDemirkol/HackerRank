


//https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem?isFullScreen=true challenge

int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

List<int> result = Result.ClimbingLeaderboard(ranked, player);

Console.WriteLine(String.Join("\n", result));

//Sample Input 0
//7
//100 100 50 40 40 20 10
//4
//5 25 50 120

//Sample Output 1
//6
//4
//2
//1

//Sample Input 2
//6
//100 90 90 80 75 60
//5
//50 65 77 90 102

//Sample Output 2
//6
//5
//4
//2
//1