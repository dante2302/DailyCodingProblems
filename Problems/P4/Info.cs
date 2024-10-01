using Problems.utils;

namespace Problems.P4;

public class Info : IProblemDescriptor
{
    public string Difficulty => "Medium";
    public string Description  => @"
        Good morning! Here's your coding interview problem for today.

        This problem was asked by Microsoft.

        Compute the running median of a sequence of numbers and add it to an Answer array. 
        That is, given a stream of numbers, push the median of the list so far.

        Recall that the median of an even-numbered list is the average of the two middle numbers.";
    public string Heading  => "Running Median";
}