using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        // Arrange
        long n = 1;

        // Act & Assert
        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(n), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long n = 41;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(n);
        
        // Assert
        Assert.AreEqual(n, result);

    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long n = 600851475143;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(n);

        // Assert
        Assert.AreEqual(6857, result);
    }
}
