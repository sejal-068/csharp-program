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

    public void DFS(int start, bool[] visited)
    {
        visited[start] = true;
        Console.Write(start + " ");

        foreach (var n in adj[start])
        {
            if (!visited[n])
                DFS(n, visited);
        }
    }
}

class Program
{
    static void Main()
    {
        Graph g = new Graph(5);
        g.AddEdge(0,1);
        g.AddEdge(0,2);
        g.AddEdge(1,3);
        g.AddEdge(2,4);

        bool[] visited = new bool[5];

        Console.Write("DFS: ");
        g.DFS(0, visited);
    }
}