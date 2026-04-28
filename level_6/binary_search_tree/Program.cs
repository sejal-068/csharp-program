class BST
{
    public Node root;

    // Insert
    public Node Insert(Node root, int key)
    {
        if (root == null)
            return new Node(key);

        if (key < root.data)
            root.left = Insert(root.left, key);
        else
            root.right = Insert(root.right, key);

        return root;
    }

    // Search
    public bool Search(Node root, int key)
    {
        if (root == null)
            return false;

        if (root.data == key)
            return true;

        if (key < root.data)
            return Search(root.left, key);
        else
            return Search(root.right, key);
    }

    // Find minimum
    private Node MinValue(Node node)
    {
        while (node.left != null)
            node = node.left;
        return node;
    }

    // Delete
    public Node Delete(Node root, int key)
    {
        if (root == null) return root;

        if (key < root.data)
            root.left = Delete(root.left, key);
        else if (key > root.data)
            root.right = Delete(root.right, key);
        else
        {
            if (root.left == null)
                return root.right;
            else if (root.right == null)
                return root.left;

            Node temp = MinValue(root.right);
            root.data = temp.data;
            root.right = Delete(root.right, temp.data);
        }
        return root;
    }
}