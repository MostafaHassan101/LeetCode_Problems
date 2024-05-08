// 506. Relative Ranks
public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        string[] places = ["Gold Medal","Silver Medal","Bronze Medal"];
        List<string> res = new();
        var sortedScore = score.OrderByDescending(s => s).ToArray();
        for(int i = 0; i < score.Length; i++)
        {
            int index = Array.IndexOf(sortedScore, score[i]);
            if(score[i] == sortedScore[0])
                res.Add(places[0]);
            else if (score[i] == sortedScore[1])
                res.Add(places[1]);
            else if (score[i] == sortedScore[2])
                res.Add(places[2]);
            else
                res.Add((index + 1).ToString());
            
        }
        return res.ToArray();
    }
}