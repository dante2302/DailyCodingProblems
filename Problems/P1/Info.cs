using Problems.utils;
namespace Problems.P1;

public class Info : IProblemDescriptor
{
    public string Heading { get; }  = "First Missing Positive Integer";
    public string Description { get; } = @"
        Given an array of integers, find the first missing positive integer. 
        In other words, find the lowest positive integer that does not exist in the array. 
        The array can contain duplicates and negative numbers as well.
        For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.
        You can modify the input array in-place.";

    public ProblemDifficulty Difficulty { get; } = ProblemDifficulty.Medium;
}