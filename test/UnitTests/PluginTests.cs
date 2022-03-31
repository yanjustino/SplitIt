using System;
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

    [Fact]
    public void TheLimitOfCharactersShouldGreatThanZero()
    {
        var text = _fixture.DefaultText;
        Assert.Throws<ArgumentNullException>(() => text!.SplitIt(0));
    }
}