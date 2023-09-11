
internal class MyBook : Book
{
    private int price;

    public MyBook(string t, string a, int price) : base(t, a)
    {
        this.price = price;
    }

    public override void display()
    {
        Console.WriteLine("Title: "+title);
        Console.WriteLine("Author: "+author);
        Console.WriteLine("Price: "+price);
    }
}