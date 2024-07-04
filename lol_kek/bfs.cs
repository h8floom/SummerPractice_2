namespace lol_kek;
public class DFS
{
    private int[,] adjacencyMatrix;
    private int vertices;

    public DFS(int[,] adjacencyMatrix)
    {
        this.adjacencyMatrix = adjacencyMatrix;
        this.vertices = adjacencyMatrix.GetLength(0);
    }

    public List<int> DepthFirstSearch(int startVertex)
    {
        bool[] visited = new bool[vertices];
        List<int> result = new List<int>();
        Stack<int> stack = new Stack<int>();

        stack.Push(startVertex);

        while (stack.Count > 0)
        {
            int currentVertex = stack.Pop();

            if (!visited[currentVertex])
            {
                visited[currentVertex] = true;
                result.Add(currentVertex);

                for (int i = 0; i < vertices; i++)
                {
                    if (adjacencyMatrix[currentVertex, i] == 1 && !visited[i])
                    {
                        stack.Push(i);
                    }
                }
            }
        }

        return result;
    }
}

