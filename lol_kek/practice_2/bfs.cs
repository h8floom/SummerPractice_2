using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol_kek.practice_2;
public class BFS
{
    private int[,] adjacencyMatrix;
    private int vertices;

    public BFS(int[,] adjacencyMatrix)
    {
        this.adjacencyMatrix = adjacencyMatrix;
        vertices = adjacencyMatrix.GetLength(0);
    }

    public List<int> BreadthFirstSearch(int startVertex)
    {
        bool[] visited = new bool[vertices];
        List<int> result = new List<int>();
        Queue<int> queue = new Queue<int>();

        visited[startVertex] = true;
        queue.Enqueue(startVertex);

        while (queue.Count > 0)
        {
            int currentVertex = queue.Dequeue();
            result.Add(currentVertex);

            for (int i = 0; i < vertices; i++)
            {
                if (adjacencyMatrix[currentVertex, i] == 1 && !visited[i])
                {
                    visited[i] = true;
                    queue.Enqueue(i);

                }
            }
        }

        return result;
    }
}
