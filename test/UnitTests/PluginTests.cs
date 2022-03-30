using System;
using Xunit;

namespace UnitTests;

public class PluginTests
{
    [Fact]
    public void TheTextShouldNotBeNullOrEmpty()
    {
        string? text = null;
        Assert.Throws<ArgumentNullException>(() => Split.It(text, 40));
    }
}