using Problems.utils;

namespace Problems.P1;

public class Solution : ISolution
{
    public int Method(int[] numbers)
    {
        int n = numbers.Length;
        bool isPresent = false;

        // Changing values to 1 
        for (int i = 0; i < n; i++)
        {
            if(numbers[i] == 1)
                isPresent = true;

            if (numbers[i] <= 0 || numbers[i] > n)
                numbers[i] = 1;
        }

        // if 1 is not present, then 1 is the answer
        if (!isPresent) return 1;

        // Updating indices according to values
        for (int i = 0; i < n; i++)
            numbers[(numbers[i] - 1) % n] += n;

        // Finding which index has value less than n
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] <= n)
                return i + 1;
        }

        return n + 1;
    }
    public SolutionInfo Info {get; set;} = new()
    {
        Approach = @"
            Mark the elements in the array 
            which are greater than N and less than 1 with 1.",
        TimeComplexity = "O(N)",
        SpaceComplexity = "O(1)",
        TimeSpent = "23:55"
    };
}