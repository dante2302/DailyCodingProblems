using Problems.P1;
namespace Tests;
#if !IGNORE_TESTS
public class P1 
{
    private readonly Solution _solution = new();

    [Fact]
    public void Basic()
    {
        int[] input = [3, 4, -1, 1];

        var result = _solution.Method(input);

        Assert.Equal(2, result);
    }

    [Fact]
    public void ConsecutivePositiveNumbers()
    {
        int[] input = [1, 2, 0];

        var result = _solution.Method(input);

        Assert.Equal(3, result);
    }

    [Fact]
    public void Duplicates()
    {
        int[] input = [1, 1, 0];

        var result = _solution.Method(input);

        Assert.Equal(2, result);
    }

    [Fact]
    public void NegativeNumbers()
    {
        int[] input = [-1, -2, -3];

        var result = _solution.Method(input);

        Assert.Equal(1, result);
    }

    [Fact]
    public void AllPositiveNumbers()
    {
        int[] input = [1, 2, 3, 4, 5];

        var result = _solution.Method(input);

        Assert.Equal(6, result);
    }

    [Fact]
    public void MixedNumbers()
    {
        int[] input = [7, 8, 9, 11, 12];

        var result = _solution.Method(input);

        Assert.Equal(1, result);
    }

    [Fact]
    public void SingleElement()
    {
        int[] input = [1];

        var result = _solution.Method(input);

        Assert.Equal(2, result);
    }

    [Fact]
    public void EmptyArray()
    {
        int[] input = [];

        var result = _solution.Method(input);

        Assert.Equal(1, result);
    }

    [Fact]
    public void LargeNumbers()
    {
        int[] input = [100, 200, 300, 400];

        var result = _solution.Method(input);

        Assert.Equal(1, result);
    }

    [Fact]
    public void DescendingOrder()
    {
        int[] input = [5, 4, 3, 2, 1];

        var result = _solution.Method(input);

        Assert.Equal(6, result);
    }

    [Fact]
    public void SequentialNegativeAndPositiveNumbers()
    {
        int[] input = [-1, -2, -3, 1, 2, 3];

        var result = _solution.Method(input);

        Assert.Equal(4, result);
    }

    [Fact]
    public void LargeArray()
    {
        int[] input = new int[1000];
        for (int i = 0; i < 999; i++)
        {
            input[i] = i + 2;
        }
        input[999] = -1;

        var result = _solution.Method(input);

        Assert.Equal(1, result);
    }

    [Fact]
    public void DuplicatesOnly()
    {
        int[] input = [1, 1, 1, 1, 1];

        var result = _solution.Method(input);

        Assert.Equal(2, result);
    }

    [Fact]
    public void MixedNegativesAndPositives()
    {
        int[] input = [-10, 5, 2, -3, 3];

        var result = _solution.Method(input);

        Assert.Equal(1, result);
    }
}

#endif