class Graph
{
    private int nodeList;
    private List<int>[] edgeTable;

    public Graph(int nodeCount)
    {
        nodeList = nodeCount;
        edgeTable = new List<int>[nodeCount];
        for (int i = 0; i < nodeCount; i++)
        {
            edgeTable[i] = new List<int>();
        }
    }

    public void AddEdge(int sourceNode, int destNode)
    {
        edgeTable[sourceNode].Add(destNode);
    }

    public bool IsReachable(int check1, int check2)
    {
        bool[] visited = new bool[nodeList];
        Search(check1, visited);
        return visited[check2];
    }

    private void Search(int v, bool[] visited)
    {
        visited[v] = true;
        foreach (int i in edgeTable[v])
        {
            if (!visited[i])
            {
                Search(i, visited);
            }
        }
    }
}