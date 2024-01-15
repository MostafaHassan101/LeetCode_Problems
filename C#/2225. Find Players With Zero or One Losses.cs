// 2225. Find Players With Zero or One Losses
public class Solution {
    public IList<IList<int>> FindWinners(int[][] matches) {
        var winners = new HashSet<int>();
        var lostOnes = new HashSet<int>();
        var losers = new HashSet<int>();

        foreach (var match in matches) {
            int winner = match[0];
            int loser = match[1];

            if (!winners.Contains(winner) && !lostOnes.Contains(winner) && !losers.Contains(winner))
                winners.Add(winner);

            if (!lostOnes.Contains(loser) && !losers.Contains(loser)) 
            {
                lostOnes.Add(loser);
                winners.Remove(loser);
            } 
            else 
            {
                winners.Remove(loser);
                lostOnes.Remove(loser);
                losers.Add(loser);
            }
        }

        var ans = new List<IList<int>> 
        {
            winners.OrderBy(x => x).ToList(),
            lostOnes.OrderBy(x => x).ToList()
        };

        return ans;
    }
}