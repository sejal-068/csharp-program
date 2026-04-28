using System;
using System.Collections.Generic;

class Graph
{
    private List<int>[] adj;

    public Graph(int v)
    {
        adj = new List<int>[v];
        for (int i = 0; i < v; i++)
            adj[i] = new List<int>();
    }

    public void AddEdge(int u, int v)
    {
        adj[u].Add(v);
        adj[v].Add(u);
    }

    public bool HasCycle(int v, bool[] visited, int parent)
    {
        visited[v] = true;

        foreach (var n in adj[v])
        {
            if (!visited[n])
            {
                if (HasCycle(n, visited, v))
                    return true;
            }
            else if (n != parent)
                return true;
        }
        return false;
    }
}

class Program
{
    static void Main()
    {
        Graph g = new Graph(3);
        g.AddEdge(0,1);
        g.AddEdge(1,2);
        g.AddEdge(2,0);

        bool[] visited = new bool[3];

        Console.WriteLine(g.HasCycle(0, visited, -1));
    }
}