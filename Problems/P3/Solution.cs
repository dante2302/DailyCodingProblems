using Problems.utils;

namespace Problems.P3;

public class Solution : ISolution
{
    public bool Method(string s)
    {
        s = s.ToLower();
        Dictionary<char, int> d = [];
        foreach(char c in s)
            d[c] = d.TryGetValue(c, out int value) ? value + 1 : 1;

        if(s.Length % 2 == 0)
        {
            return d.Values.All(v => v % 2 == 0);
        } 

        else 
        {
            bool oddOccurence = false;
            foreach(int i in d.Values)
            {
                if(i % 2 == 0)
                    continue;

                if(oddOccurence)
                    return false;

                oddOccurence = true;
            }
            return true;
        }
    }

    public SolutionInfo Info { get; set; } = new()
    {
        Approach = @"Count the number of occurences for each char and think of a basic way to determine a palindrome",
        TimeComplexity = "O(N)",
        SpaceComplexity = "O(N)",
        TimeSpent = "15:18"
    };
}
