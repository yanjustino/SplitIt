using System;
using SplitIt;
using Xunit;

namespace UnitTests;

public class PluginTests
{
    [Fact]
    public void TheTextShouldNotBeNull()
    {
        string? text = null;
        Assert.Throws<ArgumentNullException>(() => text!.SplitIt(40));
    }
    
    [Fact]
    public void TheTextShouldNotBeEmpty()
    {
        var text = String.Empty;
        Assert.Throws<ArgumentNullException>(() => text!.SplitIt(40));
    }    
}