


//https://www.hackerrank.com/challenges/30-linked-list-deletion/problem?isFullScreen=true challenge

Node head = null;
int T = Int32.Parse(Console.ReadLine());
while (T-- > 0)
{
    int data = Int32.Parse(Console.ReadLine());
    head = Insert(head, data);
}
head = RemoveDuplicates(head);
Display(head);


static Node RemoveDuplicates(Node head)
{
    var curr = head;
    
    while (curr.next != null)
    {
        if (curr.data == curr.next.data)
        {
            curr.next = curr.next.next;
        }
        else
        {
            curr = curr.next;
        }
    }

    return head;
}

static Node Insert(Node head, int data)
{
    Node p = new Node(data);


    if (head == null)
        head = p;
    else if (head.next == null)
        head.next = p;
    else
    {
        Node start = head;
        while (start.next != null)
            start = start.next;
        start.next = p;

    }
    return head;
}
static void Display(Node head)
{
    Node start = head;
    while (start != null)
    {
        Console.Write(start.data + " ");
        start = start.next;
    }
}



//Sample Input
//6
//1
//2
//2
//3
//3
//4

//Sample Output
//1 2 3 4 