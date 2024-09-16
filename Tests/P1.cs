using Problems.P1;
namespace Tests;

public class P1
{
    private readonly Solution _solution = new();
    [Fact]
    public void Test__Basic()
    {
        var input = new[] { 3, 4, -1, 1 };
        var result = _solution.Method(input);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Test__ConsecutivePositiveNumbers()
    {
        var input = new[] { 1, 2, 0 };
        var result = _solution.Method(input);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Test__Duplicates()
    {
        var input = new[] { 1, 1, 0 };
        var result = _solution.Method(input);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Test__NegativeNumbers()
    {
        var input = new[] { -1, -2, -3 };
        var result = _solution.Method(input);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Test__AllPositiveNumbers()
    {
        int[] input = [1, 2, 3, 4, 5];
        var result = _solution.Method(input);
        Assert.Equal(6, result);
    }

    [Fact]
    public void Test__MixedNumbers()
    {
        int[] input = [7, 8, 9, 11, 12];
        var result = _solution.Method(input);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Test__SingleElement()
    {
        int[] input = [1];
        var result = _solution.Method(input);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Test__EmptyArray()
    {
        int[] input = [];
        var result = _solution.Method(input);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Test__LargeNumbers()
    {
        var input = new[] { 100, 200, 300, 400 };
        var result = _solution.Method(input);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Test__DescendingOrder()
    {
        var input = new[] { 5, 4, 3, 2, 1 };
        var result = _solution.Method(input);
        Assert.Equal(6, result);
    }

    [Fact]
    public void Test__SequentialNegativeAndPositiveNumbers()
    {
        var input = new[] { -1, -2, -3, 1, 2, 3 };
        var result = _solution.Method(input);
        Assert.Equal(4, result);
    }

    [Fact]
    public void Test__LargeArray()
    {
        var input = new int[1000];
        for (int i = 0; i < 999; i++)
        {
            input[i] = i + 2; // 2 to 1000
        }
        input[999] = -1; // Adding a negative number
        var result = _solution.Method(input);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Test__DuplicatesOnly()
    {
        var input = new[] { 1, 1, 1, 1, 1 };
        var result = _solution.Method(input);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Test__MixedNegativesAndPositives()
    {
        var input = new[] { -10, 5, 2, -3, 3 };
        var result = _solution.Method(input);
        Assert.Equal(1, result);
    }
}