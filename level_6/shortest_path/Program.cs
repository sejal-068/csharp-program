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

    public void ShortestPath(int src)
    {
        int n = adj.Length;
        int[] dist = new int[n];

        for (int i = 0; i < n; i++)
            dist[i] = -1;

        Queue<int> q = new Queue<int>();
        dist[src] = 0;
        q.Enqueue(src);

        while (q.Count > 0)
        {
            int node = q.Dequeue();

            foreach (var nbh in adj[node])
            {
                if (dist[nbh] == -1)
                {
                    dist[nbh] = dist[node] + 1;
                    q.Enqueue(nbh);
                }
            }
        }

        for (int i = 0; i < n; i++)
            Console.WriteLine($"Dist {src}->{i} = {dist[i]}");
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

        g.ShortestPath(0);
    }
}