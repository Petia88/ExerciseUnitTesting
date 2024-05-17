using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool isValidEmail = Email.IsValidEmail(validEmail);

        // Assert
        Assert.That(isValidEmail, Is.EqualTo(true));
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string invalidMail = "test.example.com";

        // Act
        bool isValidEmail = Email.IsValidEmail(invalidMail);

        // Assert
        Assert.IsFalse(isValidEmail);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string nullMail = null;

        // Act
        bool isValidEmail = Email.IsValidEmail(nullMail);

        // Assert
        Assert.IsFalse(isValidEmail);
    }
}
