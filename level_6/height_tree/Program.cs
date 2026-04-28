using System;

class Node
{
    public int data;
    public Node left, right;
}

class Program
{
    // ✅ Method class ke andar hona chahiye
    public static int Height(Node root)
    {
        if (root == null)
            return 0;

        return 1 + Math.Max(Height(root.left), Height(root.right));
    }

    static void Main()
    {
        Console.WriteLine("Program running...");
    }
}