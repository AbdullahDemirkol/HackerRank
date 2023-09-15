

//https://www.hackerrank.com/challenges/30-nested-logic/problem?isFullScreen=true challenge


var a = Console.ReadLine().Split(' ').ToList().Select(x=>Convert.ToInt32(x)).ToList();

var d1 = a[0];
var m1 = a[1];
var y1 = a[2];

a = Console.ReadLine().Split(' ').ToList().Select(x => Convert.ToInt32(x)).ToList();

var d2 = a[0];
var m2 = a[1];
var y2 = a[2];

var result = Library.CheckDate(d1,d2,m1,m2,y1,y2);

Console.WriteLine(result);



//Sample Input
//9 6 2015    day = 9, month = 6, year = 2015(date returned)
//6 6 2015    day = 6, month = 6, year = 2015(date due)

//Sample Output
//45