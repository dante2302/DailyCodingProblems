namespace Problems.utils;

public interface IProblemDescriptor
{
    public string Heading { get; }
    public string Description { get; }
    public ProblemDifficulty Difficulty { get; }
}
