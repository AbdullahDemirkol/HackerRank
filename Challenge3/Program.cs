using Challenge3;

//https://www.hackerrank.com/challenges/30-operators/problem challenge

double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

Result.Solve(meal_cost, tip_percent, tax_percent);

Console.ReadLine();


// Sample Output
//12.00
//20
//8

//Sample Output
//15