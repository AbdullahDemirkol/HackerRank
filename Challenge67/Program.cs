


//https://www.hackerrank.com/challenges/30-binary-trees/problem?isFullScreen=true challenge


Node root = null;
int T = Int32.Parse(Console.ReadLine());
while (T-- > 0)
{
    int data = Int32.Parse(Console.ReadLine());
    root = Insert(root, data);
}
LevelOrder(root);


bool Flag = true;
static void LevelOrder(Node root)
{
   var q=new Queue<Node>();
    q.Enqueue(root);
    while (q.Count != 0)
    {
        Node curr=q.Dequeue();
        Console.Write(curr.data+" ");
        if (curr.left!=null)
        {
            q.Enqueue(curr.left);
        }
        if (curr.right!=null)
        {
            q.Enqueue(curr.right);
        }
    }
}

static Node Insert(Node root, int data)
{
    if (root == null)
    {
        return new Node(data);
    }
    else
    {
        Node cur;
        if (data <= root.data)
        {
            cur = Insert(root.left, data);
            root.left = cur;
        }
        else
        {
            cur = Insert(root.right, data);
            root.right = cur;
        }
        return root;
    }
}


//Sample Input
//6
//3
//5
//4
//7
//2
//1

//Sample Output
//3 2 5 1 4 7 