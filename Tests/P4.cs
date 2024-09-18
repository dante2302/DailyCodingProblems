using Problems.P4;

namespace Tests;

public class P4
{
    private Solution _solution = new();

    [Fact]
    public void BasicCase()
    {
        int[] input = [2, 1, 5, 7, 2, 0, 5];
        double[] expected = [2, 1.5, 2, 3.5, 2, 2, 2]; 

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void EmptyArray()
    {
        int[] input = [];
        double[] expected = [];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void SingleElement()
    {
        int[] input = [1];
        double[] expected = [1];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void TwoElements_IntMedian()
    {
        int[] input = [1,3];
        double[] expected = [1,2];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void TwoElements_DoubleMedian()
    {
        int[] input = [1,2];
        double[] expected = [1,1.5];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void TwoElements_Same()
    {
        int[] input = [1,1];
        double[] expected = [1,1];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void ThreeElements_Same()
    {
        int[] input = [1,1,1];
        double[] expected = [1,1,1];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void EvenNumbers_EvenLength()
    {
        int[] input = [16, 2, 4, 10, 20, 14];
        double[] expected = [16, 9, 2, 7, 10, 12]; 

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void EvenNumbers_OddLength()
    {
        int[] input = [16, 2, 4, 10, 20];
        double[] expected = [16, 9, 2, 7, 10]; 

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void OddNumbers_EvenLength()
    {
        int[] input = [15, 1, 5, 13, 21, 19];
        double[] expected = [15, 8, 5, 9, 13, 14]; 

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void OddNumbers_OddLength()
    {
        int[] input = [15, 1, 5, 13, 21, 19, 27];
        double[] expected = [15, 8, 5, 9, 13, 14, 15]; 

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }
}