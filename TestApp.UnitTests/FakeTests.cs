using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        // Act + Assert
        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        //Arange
        char[] input = new char[] { '0', '1', 'a', 'b' };

        //Act
        char[] result = Fake.RemoveStringNumbers(input);

        //Assert
        Assert.That(result, Is.EqualTo(new[] { 'a', 'b' }));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        //Arange
        char[] input = new char[] { 'c', 'd', 'a', 'b' };

        //Act
        char[] result = Fake.RemoveStringNumbers(input);

        //Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        //Arange
        char[] input = Array.Empty<char>();

        //Act
        char[] result = Fake.RemoveStringNumbers(input);

        //Assert
        Assert.That(result, Is.Empty);
    }
}
