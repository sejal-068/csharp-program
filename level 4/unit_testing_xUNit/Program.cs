using Xunit;

public class TestClass
{
    [Fact]
    public void Add_Test()
    {
        int result = 2 + 3;
        Assert.Equal(5, result);
    }
}