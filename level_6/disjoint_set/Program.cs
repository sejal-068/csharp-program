using System;

class DisjointSet
{
    int[] parent;

    public DisjointSet(int n)
    {
        parent = new int[n];
        for (int i = 0; i < n; i++)
            parent[i] = i;
    }

    public int Find(int x)
    {
        if (parent[x] != x)
            parent[x] = Find(parent[x]);
        return parent[x];
    }

    public void Union(int x, int y)
    {
        int px = Find(x);
        int py = Find(y);

        if (px != py)
            parent[px] = py;
    }
}

class Program
{
    static void Main()
    {
        DisjointSet ds = new DisjointSet(5);

        ds.Union(1,2);
        Console.WriteLine(ds.Find(2));
    }
}