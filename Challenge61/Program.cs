

//https://www.hackerrank.com/challenges/30-abstract-classes/problem?isFullScreen=true challenge


string title = Console.ReadLine();
string author = Console.ReadLine();
int price = Int32.Parse(Console.ReadLine());
Book new_novel = new MyBook(title, author, price);
new_novel.display();

//Sample Input
//The Alchemist
//Paulo Coelho
//248

//Sample Output
//Title: The Alchemist
//Author: Paulo Coelho
//Price: 248