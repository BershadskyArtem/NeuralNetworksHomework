using NeuralNetworksHomework.Core.Operations;
using Xunit;

namespace NeuralNetworksHomework.Tests;

public class XorTests
{
    private static readonly int[,] XorTable = new int[,]
    {
        //00 01
        //10 11
        { 0, 1 },
        { 1, 0 }
    };
    
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 0)]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    public void XorShouldBeEqualToXorTable(int i1, int i2)
    {
        var xorOp = new XorOperation();
        var result = xorOp.Run(new double[] { i1, i2 });
        Assert.Equal(XorTable[i1, i2], result);
    }
}