using IstheStringUppercase;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void IsUpperCase_OneLowercaseLetter_ShouldReturn_False()
    {
        string input = "a";
        bool result = Kata.IsUpperCase(input);
        
        Assert.Equal(result, false);
    }
    
    [Fact]
    public void IsUpperCase_OneupperCase_ShouldBReturn_True()
    {
        string input = "A";
        bool result = Kata.IsUpperCase(input);
        
        Assert.Equal(result, true);
    }
    [Theory]
    [InlineData("An", true)]
    [InlineData("nA", true)]
    [InlineData("nnnnnA", true)]
    [InlineData("test", false)]
    [InlineData("HELLO I AM DONALD", true)]
    [InlineData("hello i am donald", false)]
    public void IsUpperCase_Multiple_ShouldBReturn_Expected(string input, bool expected)
    {
        bool result = Kata.IsUpperCase(input);
        Assert.Equal(result, expected);
    }
}
