


//https://www.hackerrank.com/domains/algorithms?filters%5Bstatus%5D%5B%5D=unsolved&badge_type=problem-solving challenge


int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

int result = Result.SockMerchant(n, ar);

Console.WriteLine(result);


//Sample Input
//9                               n = 9
//10 20 20 10 10 30 50 10 20      ar = [10, 20, 20, 10, 10, 30, 50, 10, 20]

//Sample Output
//3