class Graph
{
    private int[,] adjMatrix;
    private int vertices;

    public Graph(int v)
    {
        vertices = v;
        adjMatrix = new int[v, v];
    }

    public void AddEdge(int u, int v)
    {
        adjMatrix[u, v] = 1;
        adjMatrix[v, u] = 1; // undirected graph
    }

    public void PrintGraph()
    {
        for (int i = 0; i < vertices; i++)
        {
            for (int j = 0; j < vertices; j++)
            {
                Console.Write(adjMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}