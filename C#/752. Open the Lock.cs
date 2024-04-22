// 752. Open the Lock
public class Solution {
    public int OpenLock(string[] deadends, string target) {
        var dead = new HashSet<string>(deadends);
        if (dead.Contains("0000")) return -1;
        if (target == "0000") return 0;
        var visited = new HashSet<string>();
        visited.Add("0000");
        var q = new Queue<string>();
        q.Enqueue("0000");
        int steps = 0;
        while (q.Count > 0) {
            steps++;
            int size = q.Count;
            for (int i = 0; i < size; i++) {
                var cur = q.Dequeue();
                for (int j = 0; j < 4; j++) {
                    for (int k = -1; k <= 1; k += 2) {
                        var next = cur.ToCharArray();
                        next[j] = (char)((next[j] - '0' + k + 10) % 10 + '0');
                        var nextStr = new string(next);
                        if (nextStr == target) return steps;
                        if (!dead.Contains(nextStr) && !visited.Contains(nextStr)) {
                            visited.Add(nextStr);
                            q.Enqueue(nextStr);
                        }
                    }
                }
            }
        }
        return -1;
    }
}