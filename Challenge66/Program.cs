

Node root = null;
int T = Int32.Parse(Console.ReadLine());
while (T-- > 0)
{
    int data = Int32.Parse(Console.ReadLine());
    root = Insert(root, data);
}
int height = GetHeight(root);
Console.WriteLine(height);



static int GetHeight(Node root)
{
    if (root==null)
    {
        return -1;
    }
    var leftHeight=GetHeight(root.left);
    var rightHeight=GetHeight(root.right);
    
    if (leftHeight>rightHeight)
    {
        return leftHeight +1;
    }
    else
    {
        return rightHeight +1;
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