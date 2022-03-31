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
        var text = "test test test";
        var expected = "test\r\ntest\r\ntest\r\n";

        var result = text.SplitIt(4);
        result.Should().Be(expected);
    }    
}