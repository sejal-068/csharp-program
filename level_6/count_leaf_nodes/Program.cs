using System;

class Node
{
    public int data;
    public Node left, right;

    public Node(int value)
    {
        data = value;
        left = right = null;
    }
}

class Program
{
    // ✅ Function to count leaf nodes
    public static int CountLeaves(Node root)
    {
        if (root == null)
            return 0;

        // if both children are null → leaf node
        if (root.left == null && root.right == null)
            return 1;

        return CountLeaves(root.left) + CountLeaves(root.right);
    }

    static void Main()
    {
        // Creating sample tree
        Node root = new Node(1);
        root.left = new Node(2);
        root.right = new Node(3);
        root.left.left = new Node(4);
        root.left.right = new Node(5);

        Console.WriteLine("Leaf Nodes Count: " + CountLeaves(root));
    }
}