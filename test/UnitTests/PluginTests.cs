using System;
using FluentAssertions;
using SplitIt;
using Xunit;

namespace UnitTests;

public class PluginTests: IClassFixture<PluginTestsFixture>
{
    private readonly PluginTestsFixture _fixture;

    public PluginTests(PluginTestsFixture fixture)
    {
        _fixture = fixture;
    }
    
    [Fact]
    public void TheTextShouldNotBeNull()
    {
        string? text = null;
        Assert.Throws<ArgumentNullException>(() => text!.SplitIt(40));
    }
    
    [Fact]
    public void TheTextShouldNotBeEmpty()
    {
        var text = string.Empty;
        Assert.Throws<ArgumentNullException>(() => text!.SplitIt(40));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-10)]
    public void TheLimitOfCharactersShouldGreatThanZero(int limite)
    {
        var text = _fixture.DefaultText;
        Assert.Throws<ArgumentNullException>(() => text!.SplitIt(limite));
    }
    
    [Fact]
    public void TheTextShouldBeSplitIntoThreeLines()
    {
        const string text = "test1 test2 test3.";
        const string expected = "test1\ntest2\ntest3.";

        var result = text.SplitIt(5);
        result.Should().Be(expected);
    }    
    
    [Fact]
    public void TheDefaultTextShouldBeSplitInto40CharacterLines()
    {
        var text = _fixture.DefaultText;
        var expected = _fixture.ExpectedTextIn40Character;

        var result = text.SplitIt(40);
        result.Should().Be(expected);
    }  
    
    [Fact]
    public void TheTextShouldNotBeSplit()
    {
        const string text = "test1 test2 test3.";
        
        Assert.Throws<ArgumentOutOfRangeException>(() => text!.SplitIt(2));
    }     
}