


//https://www.hackerrank.com/challenges/designer-pdf-viewer/problem?isFullScreen=true challenge


List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

string word = Console.ReadLine();

int result = Result.DesignerPdfViewer(h, word);

Console.WriteLine(result);


//Sample Input 0
//1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5
//abc

//Sample Output 0
//9

//Sample Input 1
//1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 7
//zaba

//Sample Output 1
//28