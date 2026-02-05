using MyPowerLib;

namespace MyPowerLibTest;

public class UnitTest1
{
    [Fact]
    public void TestTwoNumbers()
    {
        // Arrange
        double expected = 8; // 2 to the power of 3 [cite: 92]
        // Act
        double actual = Power.MyPow(2, 3);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestThreeNumbers()
    {
        // Arrange
        double expected = 4096; // (2^3)^4 = 8^4 [cite: 92]
        // Act
        double actual = Power.MyPow(2, 3, 4);
        // Assert
        Assert.Equal(expected, actual);
    }
}