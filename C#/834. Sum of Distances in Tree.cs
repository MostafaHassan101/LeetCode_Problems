//  834. Sum of Distances in Tree

public class Solution {
    public int[] SumOfDistancesInTree(int n, int[][] edges) {
        var graph = new List<int>[n];
        for (int i = 0; i < n; i++) {
            graph[i] = new List<int>();
        }
        foreach (var edge in edges) {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }
        var count = new int[n];
        var res = new int[n];
        Dfs1(graph, 0, -1, count, res);
        Dfs2(graph, 0, -1, count, res);
        return res;
    }

    private void Dfs1(List<int>[] graph, int node, int parent, int[] count, int[] res) {
        count[node] = 1;
        foreach (var child in graph[node]) {
            if (child == parent) {
                continue;
            }
            Dfs1(graph, child, node, count, res);
            count[node] += count[child];
            res[node] += res[child] + count[child];
        }
    }

    private void Dfs2(List<int>[] graph, int node, int parent, int[] count, int[] res) {
        foreach (var child in graph[node]) {
            if (child == parent) {
                continue;
            }
            res[child] = res[node] - count[child] + count.Length - count[child];
            Dfs2(graph, child, node, count, res);
        }
    }
    
}