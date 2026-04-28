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

class BinaryTree
{
    public Node root;

    // Inorder
    public void Inorder(Node node)
    {
        if (node == null) return;
        Inorder(node.left);
        Console.Write(node.data + " ");
        Inorder(node.right);
    }

    // Preorder
    public void Preorder(Node node)
    {
        if (node == null) return;
        Console.Write(node.data + " ");
        Preorder(node.left);
        Preorder(node.right);
    }

    // Postorder
    public void Postorder(Node node)
    {
        if (node == null) return;
        Postorder(node.left);
        Postorder(node.right);
        Console.Write(node.data + " ");
    }
}