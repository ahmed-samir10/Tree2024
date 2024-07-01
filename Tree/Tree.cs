using Tree;


internal class BTree
{
    public Node Roote;

    public BTree(int value)
    {
        Roote = new Node(value);
    }

    public void Insert(int value)
    {
        InsertRecursive(Roote, value);
    }

    private void InsertRecursive(Node current, int value)
    {
        if (value <= current.value)// go left
        {
            if (current.left == null)
            {
                current.left = new Node(value);
            }
            else
            {
                InsertRecursive(current.left, value);
            }
        }
        else // go R
        {
            if (current.right == null)
            {
                current.right = new Node(value);
            }
            else
            {
                InsertRecursive(current.right, value);
            }
        }
    }

    public void DrawTree()
    {

        DrawNode(Roote, "");
    }

    private void DrawNode(Node node, string indent)
    {
        if (node != null)
        {
            DrawNode(node.right, indent + "    ");
            Console.WriteLine(indent + node.value);
            DrawNode(node.left, indent + "    ");
        }
    }

    public void Remove(int value)
    {
        Roote = RemoveRecursive(Roote, value);
    }

    private Node RemoveRecursive(Node current, int value)
    {
        if (current == null)
        {
            return null;
        }

        if (value == current.value)
        {
            // Case 1: No child or only one child
            if (current.left == null)
            {
                return current.right;
            }
            else if (current.right == null)
            {
                return current.left;
            }

            // Case 2: Two children
            current.value = FindMinValue(current.right);
            current.right = RemoveRecursive(current.right, current.value);
            return current;
        }

        if (value < current.value)
        {
            current.left = RemoveRecursive(current.left, value);
        }
        else
        {
            current.right = RemoveRecursive(current.right, value);
        }

        return current;
    }
    public void del (int value)
    {
        Roote = dell(Roote, value);
    }
    public Node dell(Node current, int value)
    {

        if (current == null) return null;
        if (value == current.value)
        {
            if (current.left == null) { return current.right; }
            else if (current.right == null) { return current.left; }
            current.value = min(current.right);
            current.right = dell(current.right,current.value);
           

        }
        else if (value < current.value)
        {
            current.left = dell(current.left, value);
        }
        else current.right = dell(current.right, value);
        return current;
    }
    public int min(Node current)
    {
        int min = current.value;
        while(current.left != null) { min = current.left.value; current = current.left; }
        return min;
    }

    public void Search(int value)
    {
        Roote = SearchRecursive(Roote, value);
    }
    private Node SearchRecursive(Node current, int value)
    {
        if (current == null)
        {
            Console.WriteLine("not found.");
            return null;
        }
        if (value == current.value)
        {
            Console.WriteLine("found.");
            return current;
        }
        if (value < current.value)
        {
            current.left =SearchRecursive(current.left, value);
        }
        else
        {
            current.right =SearchRecursive(current.right, value);
        }
        return current;
    }


    private int FindMinValue(Node node)
    {
        int minv = node.value;
        while (node.left != null)
        {
            minv = node.left.value;
            node = node.left;
        }
        return minv;
    }
}
