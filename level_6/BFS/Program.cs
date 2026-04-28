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
        adj[v].Add(u); // undirected
    }

    public void BFS(int start)
    {
        bool[] visited = new bool[adj.Length];
        Queue<int> q = new Queue<int>();

        visited[start] = true;
        q.Enqueue(start);

        while (q.Count > 0)
        {
            int node = q.Dequeue();
            Console.Write(node + " ");

            foreach (var neighbor in adj[node])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    q.Enqueue(neighbor);
                }
            }
        }
    }
}