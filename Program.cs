class Program
{
    static void Main(string[] args)
    {
        int maxNodeCount = int.Parse(Console.ReadLine());
        Graph graph = new Graph(maxNodeCount);
        while (true)
        {
            int sourceNode = int.Parse(Console.ReadLine());
            if (sourceNode + 1 > maxNodeCount || sourceNode < 0)
            {
                break;
            }
            int destNode = int.Parse(Console.ReadLine());
            if (destNode + 1 > maxNodeCount || destNode < 0)
            {
                break;
            }
            graph.AddEdge(sourceNode, destNode);
        }

        int symbolCount = 0;
        bool[] visited = new bool[maxNodeCount];
        for (int i = 0; i < maxNodeCount; i++)
        {
            if (!visited[i])
            {
                visited[i] = true;
                foreach (int j in graph.edgeTable[i])
                {
                    if (!visited[j])
                    {
                        visited[j] = true;
                        symbolCount++;
                    }
                }
            }
        }
        Console.WriteLine(symbolCount);
    }
}