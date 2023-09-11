


//https://www.hackerrank.com/challenges/30-linked-list/problem?isFullScreen=true challenge


Node head = null;
int T = Int32.Parse(Console.ReadLine());
while (T-- > 0)
{
    int data = Int32.Parse(Console.ReadLine());
    head = insert(head, data);
}
display(head);

static Node insert(Node head, int data)
{
    if (head==null)
    {
        return new Node(data);
    }
    var currentNode=head;
    while (currentNode.next != null)
    {
        currentNode = currentNode.next;
    }
    currentNode.next=new Node(data);
    return head;
}

static void display(Node head)
{
    Node start = head;
    while (start != null)
    {
        Console.Write(start.data + " ");
        start = start.next;
    }
}

//Sample Input
//4       T = 4
//2       first data = 2
//3
//4
//1       fourth data = 1

//Sample Output
//2 3 4 1