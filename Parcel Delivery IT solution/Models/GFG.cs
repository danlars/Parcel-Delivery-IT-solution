// A C# program for Dijkstra's single
// source shortest path algorithm.
// The program is for adjacency matrix
// representation of the graph
using System;

class GFG
{
    // A utility function to find the
    // vertex with minimum distance
    // value, from the set of vertices
    // not yet included in shortest
    // path tree
    static int V = 33;
    private int minDistance(int[] dist,
                    bool[] sptSet)
    {
        // Initialize min value
        int min = int.MaxValue, min_index = -1;

        for (int v = 0; v < V; v++)
            if (sptSet[v] == false && dist[v] <= min)
            {
                min = dist[v];
                min_index = v;
            }

        return min_index;
    }

    private int[,] getGraph()
    {
        int[,] graph = new int[33, 33];

        graph[2, 13] = 8;
        graph[4, 24] = 4;
        graph[4, 28] = 5;
        graph[6, 8] = 5;
        graph[6, 21] = 3;
        graph[6, 23] = 10;
        graph[8, 6] = 5;
        graph[8, 25] = 3;
        graph[10, 11] = 11;
        graph[10, 21] = 4;
        graph[10, 22] = 4;
        graph[11, 10] = 11;
        graph[11, 15] = 3;
        graph[11, 22] = 9;
        graph[11, 23] = 10;
        graph[13, 2] = 8;
        graph[13, 18] = 8;
        graph[13, 24] = 4;
        graph[14, 15] = 8;
        graph[14, 18] = 3;
        graph[15, 11] = 3;
        graph[15, 14] = 8;
        graph[15, 23] = 9;
        graph[18, 13] = 8;
        graph[18, 14] = 3;
        graph[21, 6] = 3;
        graph[21, 10] = 4;
        graph[21, 23] = 11;
        graph[22, 10] = 4;
        graph[22, 11] = 9;
        graph[23, 6] = 10;
        graph[23, 11] = 10;
        graph[23, 15] = 9;
        graph[23, 21] = 11;
        graph[24, 4] = 4;
        graph[24, 13] = 4;
        graph[25, 8] = 3;
        graph[25, 28] = 3;
        graph[28, 4] = 5;
        graph[28, 25] = 3;

        return graph;
    }


    // Function that implements Dijkstra's
    // single source shortest path algorithm
    // for a graph represented using adjacency
    // matrix representation
    private int dijkstra(int[,] graph, int src, int dest)
    {
        int[] dist = new int[V]; // The output array. dist[i]
                                 // will hold the shortest
                                 // distance from src to i

        // sptSet[i] will true if vertex
        // i is included in shortest path
        // tree or shortest distance from
        // src to i is finalized
        bool[] sptSet = new bool[V];

        // Initialize all distances as
        // INFINITE and stpSet[] as false
        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            sptSet[i] = false;
        }

        // Distance of source vertex
        // from itself is always 0
        dist[src] = 0;

        // Find shortest path for all vertices
        for (int count = 0; count < V - 1; count++)
        {
            // Pick the minimum distance vertex
            // from the set of vertices not yet
            // processed. u is always equal to
            // src in first iteration.
            int u = minDistance(dist, sptSet);

            // Mark the picked vertex as processed
            sptSet[u] = true;

            // Update dist value of the adjacent
            // vertices of the picked vertex.
            for (int v = 0; v < V; v++)

                // Update dist[v] only if is not in
                // sptSet, there is an edge from u
                // to v, and total weight of path
                // from src to v through u is smaller
                // than current value of dist[v]
                if (!sptSet[v] && graph[u, v] != 0 &&
                     dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                    dist[v] = dist[u] + graph[u, v];
        }

        return dist[dest];
    }

    private int calculateTime(int segCount)
    {
        return segCount * 12;
    }

    private int calculatePrice(int segCount)
    {
        return segCount * 5;
    }

    public int shortestPathTime(int src, int dest)
    {
        return calculateTime(dijkstra(getGraph(), src, dest));
    }

    public int shortestPathPrice(int src, int dest)
    {
        return calculatePrice(dijkstra(getGraph(), src, dest));
    }
}