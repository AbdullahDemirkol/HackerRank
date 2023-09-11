

//https://www.hackerrank.com/challenges/30-interfaces/problem?isFullScreen=true challenge 


int n = Int32.Parse(Console.ReadLine());
AdvancedArithmetic myCalculator = new Calculator();
int sum = myCalculator.DivisorSum(n);
Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);

//Sample Input
//6

//Sample Output
//I implemented: AdvancedArithmetic
//12