﻿using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests;

[TestFixture]
public class ErrorLoggerTests
{
    private ErrorLogger _errorLogger;

    [SetUp]
    public void SetUp()
    {
        _errorLogger = new ErrorLogger();
    }

    [Test]
    public void Log_WhenCalled_SetTheLastErrorProperty()
    {
        var logger = _errorLogger;

        _errorLogger.Log("a");

        Assert.That(logger.LastError, Is.EqualTo("a"));
    }

    [Test]
    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void Log_InvalidError_ThrowArgumentNullException(string error)
    {
        Assert.That(() => _errorLogger.Log(error), Throws.ArgumentNullException);
    }
}