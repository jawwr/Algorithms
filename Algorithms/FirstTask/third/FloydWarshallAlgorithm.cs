namespace Algorithms.FirstTask.third
{
    public static class FloydWarshallAlgorithm
    {
        public static double[,] Calculate(double[,] graph)
        {
            var size = graph.GetLength(0);
            for (int k = 0; k < size; k++)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (graph[i, k] != uint.MaxValue
                            && graph[k, j] != uint.MaxValue
                            && graph[i, j] > graph[i, k] + graph[k, j])
                        {
                            graph[i, j] = graph[i, k] + graph[k, j];
                        }
                    }
                }
            }

            return graph;
        }
    }
}